using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass35
{

    public class BoxingUnboxing : MonoBehaviour
    {
        private int _health = 100;
        void Start()
        {
            object boxedHealth = _health; //boxing
            int unBoxedHealth = (int)boxedHealth; //unboxing

            Debug.Log("Original value : " + _health);
            Debug.Log("Boxed value : "+boxedHealth);
            Debug.Log("Unboxed and modified value : " + unBoxedHealth);

        }

    }
}