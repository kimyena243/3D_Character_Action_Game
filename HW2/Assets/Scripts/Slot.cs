using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public ItemData item; // 획득한 아이템
    public Image itemImage;  // 아이템의 이미지


    // 아이템 이미지의 투명도 조절
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    // 인벤토리에 새로운 아이템 슬롯 추가
    public void AddItem(ItemData _item)
    {
        
        item = _item;
        itemImage.sprite = item.itemImage;

        SetColor(1);
       
    }

 
}