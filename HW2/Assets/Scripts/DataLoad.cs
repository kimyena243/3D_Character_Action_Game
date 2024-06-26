using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class DataLoad : MonoBehaviour
{
    [SerializeField] private List<ItemData> items;
    public List<ItemData> Items { get => items; }

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

    List<ItemData> ParseCSV(string csvText)
    {
        List<ItemData> items = new List<ItemData>();
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
            ItemData item = new ItemData
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
