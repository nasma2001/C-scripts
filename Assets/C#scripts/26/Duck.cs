using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass26
{
    public class Duck : Creature, IRunnable, Iswimable
    {
        public void Run()
        {
            Debug.Log("Duck runs");
        }

        public void Swim()
        {
            Debug.Log("Duck swims");

        }
        public override void Speak()
        {
            Debug.Log("Duck says : Quack!");
        }
    }
}
