using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample derivedClass = new();
            derivedClass.PerformAction();
            derivedClass.printInfo();
        }
    }
}
