using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMade : MonoBehaviour
{
    GameObject[] food = new GameObject[3];
    int foodNum = 0;
    bool[] cake = new bool[3];
    bool[] hamberger = new bool[3];
    bool[] pizza = new bool[3];

    public GameObject cakePref;
    public GameObject hambergerPref;
    public GameObject pizzaPref; 
    public GameObject ParticlePref;
    public bool particle = true;

    //레시피 추가
    public Recipe recipe;
    public Recipe recipes;
   
    [SerializeField] private RecipeBook recipebook;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(recipe.RecipeData.RecipeName);
    }

    // Update is called once per frame
    void Update()
    {
        Made();
        SpawnFood();

    }
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Food"))
        {
            if (food[foodNum] == null)
            {
                food[foodNum] = other.gameObject;
                foodNum += 1;
                other.gameObject.SetActive(false);
                Debug.Log(food[0].name);
               
            }

        }
    }
    void Made()
    {
       
            if (food[0] != null && food[1] != null && food[2] != null)
            {
                if (food[0].name == "waffle" || food[1].name == "waffle" || food[2].name == "waffle")
                {
                    cake[0] = true;
                    pizza[0] = true;
                    hamberger[0] = true;
                }
                if (food[0].name == "ham" || food[1].name == "ham" || food[2].name == "ham")
                {

                    pizza[1] = true;
                    hamberger[1] = true;
                }
                if (food[0].name == "egg" || food[1].name == "egg" || food[2].name == "egg")
                {
                    cake[1] = true;
                    pizza[2] = true;

                }
                if (food[0].name == "cherry" || food[1].name == "cherry" || food[2].name == "cherry")
                {
                    cake[2] = true;

                }
                if (food[0].name == "tomato" || food[1].name == "tomato" || food[2].name == "tomato")
                {

                    hamberger[2] = true;
                }
            }
        
    }
    void SpawnFood()
    {
        if (cake[0] == true && cake[1] == true && cake[2] == true && particle == true)
        {
            Instantiate(cakePref, new Vector3(transform.position.x, 11.0f, transform.position.z), Quaternion.identity);
            Instantiate(ParticlePref, new Vector3(transform.position.x, 9.0f, transform.position.z), Quaternion.identity);
            cake[0] = false;
            particle = false;


        }
        if (hamberger[0] == true && hamberger[1] == true && hamberger[2] == true && particle == true)
        {
            Instantiate(hambergerPref, new Vector3(transform.position.x, 11.0f, transform.position.z), Quaternion.identity);
            Instantiate(ParticlePref, new Vector3(transform.position.x, 9.0f, transform.position.z), Quaternion.identity);

            hamberger[0] = false;
            particle = false;
        }
        if (pizza[0] == true && pizza[1] == true && pizza[2] == true && particle == true || Input.GetMouseButtonDown(1))//확인할려고 마우스 클릭 잠간 넣어둠
        {
            Instantiate(pizzaPref, new Vector3(transform.position.x, 11.0f, transform.position.z), Quaternion.identity);
            Instantiate(ParticlePref, new Vector3(transform.position.x, 9.0f, transform.position.z), Quaternion.identity);

            pizza[0] = false;
            particle = false;


            //음식 만들때 레시피 데이터 추가 & 유아이 변경
            recipebook.RecipeBookData.Add(recipe.RecipeData);
            Debug.Log(recipe.RecipeData.RecipeName);
            recipebook.AcquireItem(recipe);
            recipebook.AcquireItem(recipes);



        }

    
    }

}
