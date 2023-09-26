using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeBookData", menuName = "RecipeBook/RecipeBookData")]
public class RecipeBookData : ScriptableObject
{
    [SerializeField] private List<Recipe> recipes = new List<Recipe>();


}
