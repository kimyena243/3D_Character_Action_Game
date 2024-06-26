using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public ItemData item; // ȹ���� ������
    public Image itemImage;  // �������� �̹���


    // ������ �̹����� ���� ����
    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }

    // �κ��丮�� ���ο� ������ ���� �߰�
    public void AddItem(ItemData _item)
    {
        
        item = _item;
        itemImage.sprite = item.itemImage;

        SetColor(1);
       
    }

 
}