using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Inventory 
{
    private List<string> _itemNames = new List<string>();

    public void AddItem(string item)
    {
        _itemNames.Add(item);
    }
    public void ShowItems(){
        int counter = 0;
        foreach(string item in _itemNames)
        {
            counter++;
            Debug.Log("Item "+ counter +" : "+ item);
        }
    }
    public static Inventory operator + (Inventory inventory1,Inventory inventory2)
    {
        Inventory add = new Inventory();

        inventory1._itemNames.ForEach
        (
            itemName => add.AddItem(itemName)
        );

        inventory2._itemNames.ForEach
        (
            itemNames => add.AddItem(itemNames)
        );
        
        return add;
    }

}

