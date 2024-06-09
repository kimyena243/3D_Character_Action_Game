using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeData", menuName = "Recipe/RecipeData")]
public class RecipeData : ScriptableObject
{
    [SerializeField] private string recipeName;
    [SerializeField] private Sprite recipeIcon;
    [SerializeField] private int recipeNum;
    [SerializeField] List<Item> items;
    public string RecipeName { get => recipeName; }
    public Sprite RecipeIcon { get => recipeIcon; }
    public int RecipeNum { get => recipeNum; }

}