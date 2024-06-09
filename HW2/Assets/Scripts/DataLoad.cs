using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class DataLoad : MonoBehaviour
{
    [SerializeField] private List<Item> items;
    public List<Item> Items { get => items; }

void Start()
    {
        LoadItems();
    }

    void LoadItems()
    {
        TextAsset csvFile = Resources.Load<TextAsset>("Item");
        if (csvFile != null)
        {
            items = ParseCSV(csvFile.text);
           
        }
       
    }

    List<Item> ParseCSV(string csvText)
    {
        List<Item> items = new List<Item>();
        StringReader reader = new StringReader(csvText);
        bool isFirstLine = true;

        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            if (isFirstLine)
            {
                isFirstLine = false; // Skip header line
                continue;
            }

            string[] fields = line.Split(',');
            Item item = new Item
            {
                itemType = fields[0],
                itemName = fields[1]
                
            };
            item.name = item.itemName;
            items.Add(item);
        }

        return items;
    }
}
