using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    GameObject target;
    public NavMeshAgent agent;
    public bool isTarget = false;
    public bool isDead = false;
    Animator animator;

    GameObject gameManager;
    public int Hp = 2;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        target = GameObject.FindWithTag("Player");
        gameManager = GameObject.Find("GameManager");
        

    }
    void Update()
    {
        if (isTarget == true)
        {
            agent.destination = target.transform.localPosition;
        }
      
        Dead();
    }
    
    void Attack()
    {
        animator.SetTrigger("doAttack");
    }
    void Dead()
    {
        if(Hp <= 0)
        {
           
            animator.SetBool("isMove", false);
            
            CancelInvoke("Attack");
            animator.SetTrigger("doDie");
            isDead = true;
            Invoke("Destroy", 1.3f);
        }
    }
    private void OnDestroy()
    {
        if (isDead == true)
        {
            gameManager.GetComponent<GameManager>().monsterNum -= 1;
        }
    }
    void Destroy()
    {
        Destroy(gameObject);
    }

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTarget = true;
            animator.SetBool("isMove", true);

            InvokeRepeating("Attack", 3.0f,3.0f);
            //gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject.GetComponent<BoxCollider>());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("attack");
            

        }
        if(collision.gameObject.CompareTag("Hand"))
        {
            Hp--;
        }
    }
}
