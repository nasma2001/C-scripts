using System.Collections;
using System.Collections.Generic;
using Ass29;
using UnityEngine;

public class TypeManagementScript : MonoBehaviour
{
    void Start()
    {
        //part1
        Animal animal = new Cat();
        animal.MakeSound();
        animal.Move();

        Animal animal1 = new();
        Cat animalCat = animal1 as Cat;
        if (animalCat != null)
        {
            animalCat.MakeSound();
            animalCat.Move();
        }

        //part2
        List<ICanFight> canFights = new() { new Cat(), new Warrior() };
        foreach (ICanFight canFight in canFights)
        {
            canFight.Attack();

            if (canFight is Cat) Debug.Log("The object is a Cat.");
            if (canFight is Warrior) Debug.Log("The object is a Warrior.");
        }
    }

}
