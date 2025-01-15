using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass35
{
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();
        public void printInfo() => Debug.Log("This is a concrete method in the abstract base class.");
    }
}
