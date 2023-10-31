using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    [SerializeField] private Image recipeicon;
    [SerializeField] private Recipe recipe;
    public Recipe Recipe { get => recipe; }

    //이걸 어떻게 사용할지 생각하기
    public void SetRecipeUI()
    {
       
        recipeicon.sprite = recipe.RecipeData.RecipeIcon;
        

    }
    public void Click()
    {
          
    }
}
