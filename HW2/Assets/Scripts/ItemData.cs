using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New ItemData", menuName = "New ItemData/ItemData")]
public class ItemData : ScriptableObject  // ���� ������Ʈ�� ���� �ʿ� X 
{
  

    public string itemName; // �������� �̸�
    public string itemType; // ������ ����
    public Sprite itemImage; // �������� �̹���(�κ� �丮 �ȿ��� ���)
 


}