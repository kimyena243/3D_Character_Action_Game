using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecipeBook : MonoBehaviour
{

    //������ ����


    [SerializeField] private RecipeBookData recipeBookData;
   
    [SerializeField] private GameObject go_SlotsParent;  // Slot���� �θ��� Grid Setting 

    public RecipeUI[] slots;  // ���Ե� �迭
    [SerializeField] private List<Sprite> images = new List<Sprite>();
    //ui�� �մ���
    // [SerializeField] private GameObject SlotPrefab;
    // [SerializeField] private List<RecipeUI> slot = new List<RecipeUI>();


    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<RecipeUI>();
        //������ �� ������ �̹��� ������� ����
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].GetComponent<Image>().sprite = images[i];
        }

    }

    public void AcquireItem(Recipe _recipe)
    {
        //������ ��ȣ �ҷ��ͼ� �̹��� �ٲٱ�
        slots[_recipe.RecipeData.RecipeNum].GetComponent<Image>().sprite = _recipe.RecipeData.RecipeIcon;

       }
}
