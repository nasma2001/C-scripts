using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass29
{
    public class CustomObjectTester : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            CustomObject customObject = new CustomObject(1, "Nasma");
            print(customObject);
            CustomObject customObject1 = new CustomObject(2, "Nasma");

            print(customObject == customObject1 ? "The first object equals the second one" :
                                    "The first object does not equal the second one");
            print(customObject != customObject1 ? "The first object does not equal the second one" :
                                    "The first object equals the second one");

        }

    }
}
