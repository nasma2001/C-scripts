using System.Collections;
using System.Collections.Generic;
using assignment16;
using UnityEngine;
namespace assignment16
{
    public class CharecterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Position soldierPosition = new Position(0, 0, 1);
            Soldier soldier = new Soldier();

            Position officerPosition = new Position(1, 1, 1);
            Officer officer = new Officer("Nasma", 100, officerPosition);

            Charecter[] charecters = { soldier, officer };

            foreach (Charecter charecter in charecters)
            {
                charecter.DisplayInfo();

            }

            Debug.Log("soldier health before attack : " + soldier.Health);
            officer.Attack(30, soldier);
            Debug.Log("soldier health after attack : " + soldier.Health);


        }

    }
}
