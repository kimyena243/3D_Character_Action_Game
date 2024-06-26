using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Inventory", menuName = "New Inventory/Inventory")]
public class InventoryData : ScriptableObject  // 게임 오브젝트에 붙일 필요 X 
{
    [SerializeField] private List<ItemData> items = new List<ItemData>();
    public List<ItemData> Items { get => items; }

    public void Add(ItemData newitem)
    {

        items.Add(newitem);

        Debug.Log(Items[0].itemName);

    }
}
