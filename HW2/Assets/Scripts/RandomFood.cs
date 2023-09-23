using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RandomFood : MonoBehaviour
{
    public static bool isCake;
    public static bool isHamberger;
    public static bool isPizza;

    public GameObject[] foods = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0, 3);
        foods[num].SetActive(true);
        if(num ==0 )
        {
            isCake = true;
            isHamberger = false;
            isPizza = false;

        }
        else if(num == 1)
        {
            isHamberger = true;
            isCake =false;
            isPizza = false;
        }
        else if(num == 2)
        {
            isPizza = true;
            isCake = false;
            isHamberger = false;
           
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

   

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            if (isCake == true)
            {
                if (other.gameObject.name == "cake(Clone)")
                {
                    SceneManager.LoadScene("Clear");
                }
                else
                {
                    SceneManager.LoadScene("GameOverAnother");
                }
            }
            if (isHamberger == true)
            {
                if (other.gameObject.name == "Hambuger(Clone)")
                {
                    SceneManager.LoadScene("Clear");
                }
                else
                {
                    SceneManager.LoadScene("GameOverAnother");
                }
            }
            if (isPizza == true)
            {
                if (other.gameObject.name == "pizza(Clone)")
                {
                    SceneManager.LoadScene("Clear");
                }
                else
                {
                    SceneManager.LoadScene("GameOverAnother");
                }
            }
        }
    }
}
