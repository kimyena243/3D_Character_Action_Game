using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public GameObject ParticleFXExplosion;
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
        if(collision.gameObject.CompareTag("Hand"))
        {
            Debug.Log("����");
            Instantiate(ParticleFXExplosion, new Vector3(transform.position.x,7.5f, transform.position.z), Quaternion.identity); //���� ����Ʈ�� �����մϴ�.

            Destroy(gameObject); //�ڱ� �ڽ��� ����ϴ�.
            
        }
    }
}
