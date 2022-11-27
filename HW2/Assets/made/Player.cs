using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float moveSpeed = 10f; // 이동 속도 지정
    //public float rotationSpeed = 360f; // 회전 속도 지정
    //CharacterController characterController;

    [SerializeField]
    private Transform characterBody;
    [SerializeField]
    private Transform cameraArm;

    bool isMove;
    public float speed = 10.0f;
    Animator animator;
    Rigidbody rig;
    bool jDown;
    bool isJump;
    Ray ray;
    RaycastHit hit;


    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        rig = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>(); // Animator 컴포넌트 가져옴
    }
    void Update()
    { 
        LookAround();
        Move();
        Jump();
        Click();
        //Get();
    }
    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = cameraArm.rotation.eulerAngles;

        //추가
        float x = camAngle.x - mouseDelta.y;
        if (x < 180f)
        {
            x = Mathf.Clamp(x, -1f, 70f);
        }
        else
        {
            x = Mathf.Clamp(x, 335f, 361f);
        }

        cameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x, camAngle.z);
    }
    private void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        isMove = moveInput.magnitude != 0;
        animator.SetBool("isMove", isMove);
        if (isMove)
        {
            Vector3 lookForward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraArm.right.x, 0f, cameraArm.right.z).normalized;
            Vector3 moveDir = lookForward * moveInput.y + lookRight * moveInput.x;

            characterBody.forward = lookForward;
            transform.position += moveDir * Time.deltaTime * speed;
        }
    }
    void Jump()
    {
        jDown = Input.GetButtonDown("Jump");
        if (jDown && !isJump)
        {
            rig.AddForce(Vector3.up * 15, ForceMode.Impulse);
            animator.SetBool("isJump", true);
            animator.SetTrigger("doJump");
            isJump = true;
        }
    }
    void Click()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      
        if (Input.GetMouseButtonDown(0))
        {
           
            animator.SetBool("isGet", true);
            animator.SetTrigger("doGet");

            if (Physics.Raycast(ray, out hit, 30))
            {
               
                if (hit.transform.gameObject.tag == "Recipe")
                {
                    Debug.Log("ss");
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetBool("isAttack", true);
            animator.SetTrigger("doAttack");

            if (Physics.Raycast(ray, out hit, 30))
            {
                if (hit.transform.gameObject.tag == "Monster")
                {
                  

                    Debug.Log("monster");
                }
            }
        }
    }
    //void Get()
    //{
       
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        animator.SetBool("isGet", true);
    //        animator.SetTrigger("doGet");

    //    }
        
    //}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            animator.SetBool("isJump", false);
            isJump = false;
        }
    }
}
