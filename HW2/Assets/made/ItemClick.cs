using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClick : MonoBehaviour
{
    public Inventory theInventory;
    public GameObject waffle;
    public GameObject cherry;
    public GameObject tomato;
    public GameObject egg;
    public GameObject ham;
    public string[] Fname = new string[6];
    public int slotNum;
    public bool isName;
    public bool isClick;

    // Start is called before the first frame update
    void Start()
    {
        isName = true;
        isClick = true;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (theInventory.slots[slotNum].item != null)
            {
                if (isName == true)
                {
                    Fname[slotNum] = theInventory.slots[slotNum].item.itemName;
               
                isName = false;
            }

            if (ham == null)
            {
                Destroy(theInventory.slots[slotNum].itemImage);
            }
            if (waffle == null)
            {
                Destroy(theInventory.slots[slotNum].itemImage);
            }
            if (cherry == null)
            {
                Destroy(theInventory.slots[slotNum].itemImage);
            }
            if (tomato == null)
            {
                Destroy(theInventory.slots[slotNum].itemImage);
            }
            if (egg == null)
            {
                Destroy(theInventory.slots[slotNum].itemImage);
            }

        }
    }
    public void Click()
    {
        if (isClick == true)
        {
            if (Fname[slotNum] == "«‹")
            {
                ham.SetActive(true);
                isClick = false;
               
            }
            else if (Fname[slotNum] == "ªß")
            {
                waffle.SetActive(true);
                isClick = false;
            }
            else if(Fname[slotNum] == "∞Ë∂ı")
            {
                egg.SetActive(true);
                isClick = false;
            }
            else if(Fname[slotNum] == "≈‰∏∂≈‰")
            {
                tomato.SetActive(true);
                isClick = false;
            }
            else if(Fname[slotNum] == "√º∏Æ")
            {
                cherry.SetActive(true);
                isClick = false;
            }
        }
        else
        {
            if (Fname[slotNum] == "«‹")
            {
                ham.SetActive(false);
                isClick = true;
            }
            else if(Fname[slotNum] == "√º∏Æ")
            {
                cherry.SetActive(false);
                isClick = true;
            }
            else if(Fname[slotNum] == "ªß")
            {
                waffle.SetActive(false);
                isClick = true;
            }
            else if (Fname[slotNum] == "∞Ë∂ı")
            {
                egg.SetActive(false);
                isClick = true;
            }
            else if (Fname[slotNum] == "≈‰∏∂≈‰")
            {
                tomato.SetActive(false);
                isClick = true;
            }
        }
    }

  
}
