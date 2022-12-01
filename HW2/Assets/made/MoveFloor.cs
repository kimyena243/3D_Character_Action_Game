using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public bool isX;
    public bool isZ;
    public float speed;
   
    public float maxX;
    public float minX;
    public float maxZ;
    public float minZ;
    float xPosition; //현재 위치(x) 저장
    float zPosition; //현재 위치(x) 저장
    float yPosition; //현재 위치(x) 저장
    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
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
        if (isX == true)
        {
            xPosition += Time.deltaTime * speed;

            if (xPosition >= maxX)

            {
                speed *= -1;

                xPosition = maxX;


            }

            else if (xPosition <= minX)

            {
                speed *= -1;

                xPosition = minX;


            }
            transform.position = new Vector3(xPosition, yPosition, zPosition);
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

         

            }

            else if (zPosition <= minZ)

            {

                speed *= -1;

                zPosition = minZ;

             

            }
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
