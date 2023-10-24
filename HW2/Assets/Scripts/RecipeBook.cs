using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBook : MonoBehaviour
{
    [SerializeField] private RecipeBookData recipeBookData;
    
    [SerializeField] private int recipeNum;
    [SerializeField]
    private GameObject go_SlotsParent;  // Slot들의 부모인 Grid Setting 
    [SerializeField] private GameObject SlotPrefab;
    [SerializeField] private List<RecipeUI> slot = new List<RecipeUI>();
    public void SetUI()
    {
        for (int i=0;i<recipeNum;i++)
        {
            GameObject go = Instantiate(SlotPrefab);
        }
        
           
    }
}
