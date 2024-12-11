using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    public Inventory potionInventory;
    public Inventory elixirInventory;
    public Inventory globalInventory;




    // Start is called before the first frame update
    void Start()
    {
        potionInventory = new Inventory();
        potionInventory.AddItem("Healing Potion");
        potionInventory.AddItem("Strength Potion");

        elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");

        globalInventory = potionInventory + elixirInventory;
        globalInventory.ShowItems();


    }

    // Update is called once per frame
    void Update()
    {

    }
}
