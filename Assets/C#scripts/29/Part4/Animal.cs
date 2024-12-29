using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

namespace Ass29
{
    public class Animal
    {
        public virtual void MakeSound() => Debug.Log("Animal sound");
        public  void Move() => Debug.Log("Animal moves");
    }
    public class Cat : Animal, ICanFight
    {
        public void Attack() => Debug.Log("Cat attacks with claws!");
        public override void MakeSound() => Debug.Log("Meow!");
        public new void Move() => Debug.Log("Cat runs quickly");
    }

    public class Warrior : ICanFight
    {
        public void Attack() => Debug.Log("Warrior attacks with a sword!");
    }

    public interface ICanFight
    {
        public void Attack();
    }

}