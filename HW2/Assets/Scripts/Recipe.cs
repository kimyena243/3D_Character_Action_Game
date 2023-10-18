using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    [SerializeField] private RecipeData recipeData;
    public RecipeData RecipeData { get => recipeData; }

    public Recipe()
    {
        recipeData = null;
        
    }

    public Recipe(RecipeData recipeData)
    {
        this.recipeData = recipeData;
      
    }
}
