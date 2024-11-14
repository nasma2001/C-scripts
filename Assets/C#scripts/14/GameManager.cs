using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14{
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player("Nesma",70);
        Enemy enemy = new Enemy("venom",80);

        Debug.Log("Player : " + player.name);
        Debug.Log("His enemy : " + enemy.name);

        Debug.Log("Healing..." + player.Heal(50));
        Debug.Log("Attaking..." + enemy.Attack(player,20));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}