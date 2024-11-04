using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int health;
    static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public int Heal(int amount)
    {
        if(health + amount <= 100)
        {
            health += amount;
            return health;
        }
        else {
            Debug.Log("Health cannot be more than 100!! so we'll take your health");
            return 0;
        }
    }

    public void Heal(bool fullRestore)
    {
        if(fullRestore) health = 100;
    }

    public static int ShowPlayerCount()
    {
        return playerCount;
    }



}

