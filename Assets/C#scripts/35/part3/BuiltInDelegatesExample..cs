using System;
using UnityEngine;

namespace ass35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action actionDelegate;
        Func<int, int> functionDelegate;
        Predicate<int> predicateDelegate;
        void Start()
        {
            //lambda function
            actionDelegate = () => Debug.Log("Hello From Action delegate!!");
            actionDelegate();

            functionDelegate = (number) => number * number;
            Debug.Log($"The square is {functionDelegate(5)}");

            predicateDelegate = (number) => number % 2 == 0? true : false;
            Debug.Log($"Is 4 even? {predicateDelegate(4)}");


        }

        //lambda expression
        // private void actionDelegate()=>Debug.Log("Hello From Action !!");

    }
}
