using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecipeBook : MonoBehaviour
{

    //유아이 관리


    [SerializeField] private RecipeBookData recipeBookData;
   
    [SerializeField] private GameObject go_SlotsParent;  // Slot들의 부모인 Grid Setting 

    public RecipeUI[] slots;  // 슬롯들 배열
    [SerializeField] private List<Sprite> images = new List<Sprite>();
    //ui에 잇던거
    // [SerializeField] private GameObject SlotPrefab;
    // [SerializeField] private List<RecipeUI> slot = new List<RecipeUI>();


    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<RecipeUI>();
        //시작할 때 레시피 이미지 흑백으로 띄우기
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].GetComponent<Image>().sprite = images[i];
        }

    }

    public void AcquireItem(Recipe _recipe)
    {
        //레시피 번호 불러와서 이미지 바꾸기
        slots[_recipe.RecipeData.RecipeNum].GetComponent<Image>().sprite = _recipe.RecipeData.RecipeIcon;

       }
}
