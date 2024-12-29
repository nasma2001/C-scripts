using System.Collections;
using System.Collections.Generic;
using Ass29;
using UnityEngine;


namespace Ass29
{
    public class UtilitesTester : MonoBehaviour
    {
        void Start()
        {
            print("The Sum is "+Utilites.Add(1, 2, 3, 7, 8, 60));
            print("Hi ".RepeatString(5));
        }


    }

}