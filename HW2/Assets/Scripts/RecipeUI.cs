using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    [SerializeField] private Image recipeicon;
    [SerializeField] private Recipe recipe;
    public Recipe Recipe { get => recipe; }

    //�̰� ��� ������� �����ϱ�
    public void SetRecipeUI()
    {
       
        recipeicon.sprite = recipe.RecipeData.RecipeIcon;
        

    }
    public void Click()
    {
          
    }
}
