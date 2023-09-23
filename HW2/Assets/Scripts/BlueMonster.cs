using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMonster : MonoBehaviour
{
    Animator animator;
    public bool isX;
    public bool isZ;
    public float speed;

    public float maxX;
    public float minX;
    public float maxZ;
    public float minZ;
    public float Y;
    float xPosition; //현재 위치(x) 저장
    float zPosition; //현재 위치(x) 저장
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        xPosition = transform.position.x;
        zPosition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        XMove();
        ZMove();
    }

    void XMove()
    {
        if( isX == true)
        {
            xPosition += Time.deltaTime * speed;

            if (xPosition >= maxX)

            {
                speed *= -1;

                xPosition = maxX;

                gameObject.transform.rotation = Quaternion.Euler(0, 270, 0);

            }
         
            else if (xPosition <= minX)

            {
              speed *= -1;

              xPosition = minX;

               gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);

            }
            transform.position = new Vector3(xPosition, Y, zPosition);
        }

    }
    void ZMove()
    {
        if (isZ == true)
        {
            zPosition += Time.deltaTime * speed;

            if (zPosition >= maxZ)

            {
                speed *= -1;

                zPosition = maxZ;

                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);

            }

            else if (zPosition <= minZ)

            {

                speed *= -1;

                zPosition = minZ;

                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            transform.position = new Vector3(xPosition, Y, zPosition);
        }
    }

}
