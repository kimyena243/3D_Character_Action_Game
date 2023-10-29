using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeBookData", menuName = "RecipeBook/RecipeBookData")]
public class RecipeBookData : ScriptableObject
{
    [SerializeField] private List<Recipe> recipes = new List<Recipe>();
    public List<Recipe> Recipes { get => recipes; }

    public void Add (RecipeData recipeData)
    {
        recipes.Add(new Recipe(recipeData));
        Debug.Log(Recipes[0].RecipeData.RecipeName);

    }
   

}
       