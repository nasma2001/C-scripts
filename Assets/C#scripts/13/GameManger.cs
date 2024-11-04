using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player firstPlayer = new Player();
        Player secondPlayer = new Player();

        firstPlayer.InitializePlayer("Nesma" , 50);
        secondPlayer.InitializePlayer("Majd" , 80);

        Debug.Log(firstPlayer.playerName + "'s health = " + firstPlayer.Heal(30)); // int heal
        Debug.Log(secondPlayer.playerName + "'s health = " + secondPlayer.Heal(30)); // int heal

        firstPlayer.Heal(true)
;       Debug.Log(firstPlayer.playerName + "'s health Healed to " + firstPlayer.health); // overloaded method

        Debug.Log("Number of Players = " + Player.ShowPlayerCount());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
