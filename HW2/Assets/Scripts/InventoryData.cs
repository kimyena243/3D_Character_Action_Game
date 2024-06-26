using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Inventory", menuName = "New Inventory/Inventory")]
public class InventoryData : ScriptableObject  // ���� ������Ʈ�� ���� �ʿ� X 
{
    [SerializeField] private List<ItemData> items = new List<ItemData>();
    public List<ItemData> Items { get => items; }

    public void Add(ItemData newitem)
    {

        items.Add(newitem);

        Debug.Log(Items[0].itemName);

    }
}
