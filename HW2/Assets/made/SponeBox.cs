using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SponeBox : MonoBehaviour
{

    public GameObject Box;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BoxSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BoxSpawn()
    {
        WaitForSeconds wait = new WaitForSeconds(interval);
        while (true)
        {
            Instantiate(Box, transform.position, Quaternion.Euler(90, 90, 0));
            yield return wait;
        }
    }
}
