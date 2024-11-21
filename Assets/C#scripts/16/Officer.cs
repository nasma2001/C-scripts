using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment16{
    public class Officer : Charecter
    {
        public Officer(string name, int health, Position position) : base(name, health, position){}

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
