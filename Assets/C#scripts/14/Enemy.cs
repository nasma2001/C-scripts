using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14{
public class Enemy : Charecter
{
    public Enemy(string name, int health) : base(name, health){}
    
    public int Attack(Charecter charecter ,int amount)
    {
        if(charecter.health - amount < 0)
            charecter.health = 0;
        else
            charecter.health -= amount;
        return charecter.health;
    }
}
}