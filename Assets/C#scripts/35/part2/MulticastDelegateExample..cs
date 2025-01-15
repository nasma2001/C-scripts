using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        delegate void MathOperation(int number);
        void Start()
        {
            MathOperation mathOperations = null;
            mathOperations += DoubleNumber;
            mathOperations += SquareNumber;
            mathOperations += CubeNumber;
            mathOperations(5);
        }
        void DoubleNumber(int number) => print($"The double of {number} = " + (number * 2));
        void SquareNumber(int number) => print($"The square of {number} = " + (number * number));
        void CubeNumber(int number) => print($"The cube of {number} = " + Mathf.Pow(number, 3));



    }
}
