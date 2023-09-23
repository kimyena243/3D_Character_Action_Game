using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBox : MonoBehaviour
{
    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            Debug.Log("음식생성");
            Instantiate(food, new Vector3(transform.position.x, transform.position.y + 3.0f, transform.position.z), Quaternion.identity); 

            Destroy(gameObject); //자기 자신을 지웁니다.

        }
    }
}
