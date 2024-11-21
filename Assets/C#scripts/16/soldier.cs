using System.Collections;
using System.Collections.Generic;
using ass14;
using UnityEngine;
using UnityEngine.TextCore.Text;
namespace assignment16
{
    public class Soldier : Charecter
    {
        public Soldier(): base(){}

        public Soldier(string name, int health, Position position) : base(name, health, position) { }


        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }

}
