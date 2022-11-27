using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;
    public bool isTarget = false;
    Animator animator;
   

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();


    }
    void Update()
    {
        if (isTarget == true)
        {
            agent.destination = target.transform.position;
        }
    }
    
    void Attack()
    {
        animator.SetTrigger("doAttack");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTarget = true;
            animator.SetBool("isMove", true);

            InvokeRepeating("Attack", 3.0f,3.0f);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            Debug.Log("0");
            

        }
    }
}
