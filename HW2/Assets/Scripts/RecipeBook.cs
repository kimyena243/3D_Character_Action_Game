using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBook : MonoBehaviour
{
    [SerializeField] private RecipeBookData recipeBookData;
    [SerializeField] private GameObject recipeUI;
    [SerializeField] private int recipeNum;
    public void SetUI()
    {
        for (int i=0;i<recipeNum;i++)
        {
            GameObject go = Instantiate(recipeUI);
        }
    }
}
