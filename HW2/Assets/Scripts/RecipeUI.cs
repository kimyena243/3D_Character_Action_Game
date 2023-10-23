using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    [SerializeField] private Image recipeicon;
    

    public void SetRecipeUI(Recipe recipe)
    {
        recipeicon.sprite = recipe.RecipeData.RecipeIcon;
        

    }
}
