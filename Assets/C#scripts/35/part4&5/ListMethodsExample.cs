using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass35
{
    public class ListMethodsExample : MonoBehaviour
    {
        void Start()
        {
            List<int> numbers = new() { 1, 4, 5, 2, 7, 8 };
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log(String.Join(", ", numbers));

            List<int> numbers2 = new() { 8, 3, 0, 9, 32 };
            List<int> filteredNumbers = numbers2.FindAll((x) => x % 2 == 0 ? true : false);
            Debug.Log(String.Join(", ", filteredNumbers));

        }
    }
}