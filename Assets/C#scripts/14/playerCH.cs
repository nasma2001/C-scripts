using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14{
public class Player : Charecter
{
    public Player(string name, int health) : base(name, health){}

    public int Heal (int amount)
    {
        if (health + amount > 100)
            health = 100;
        else
            health += amount;    
        return health;
    }
}
}
