using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
 
    [SerializeField]
    private GameObject go_SlotsParent;  // Slot들의 부모인 Grid Setting 

    public Slot[] slots;  // 슬롯들 배열

    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
    
    }

    void Update()
    {
       
    }
 
    public void AcquireItem(Item _item)
    {


        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].AddItem(_item);
                return;
            }
        }
    }
}