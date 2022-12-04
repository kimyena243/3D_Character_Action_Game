using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RandomFood : MonoBehaviour
{
    public static bool isCake =false;
    public static bool isHamberger=false;
    public static bool isPizza=false;

    public GameObject[] foods = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0, 3);
        foods[num].SetActive(true);
        if(num ==0 )
        {
            isCake = true;
      
        }
        else if(num == 1)
        {
            isHamberger = true;
        }
        else if(num == 2)
        {
            isPizza = true;
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
                if (other.gameObject.name == "cake")
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
                if (other.gameObject.name == "Hambuger")
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
                if (other.gameObject.name == "pizza")
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
