using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> gameContainer = new GameContainer<string>();
        gameContainer.SavedItem("Healing potion");
        Debug.Log(gameContainer.GetItem());

        Debug.Log(GameUtils.DescribeItem<string>(gameContainer.GetItem()));

    }


}
