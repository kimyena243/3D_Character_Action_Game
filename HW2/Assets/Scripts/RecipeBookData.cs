using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeBookData", menuName = "RecipeBook/RecipeBookData")]
public class RecipeBookData : ScriptableObject
{
    [SerializeField] private List<RecipeData> recipes = new List<RecipeData>();
    public List<RecipeData> Recipes { get => recipes; }

    public void Add (RecipeData newData)
    {
        
        recipes.Add(newData);

        Debug.Log(Recipes[0].RecipeName);

    }
   

}
       