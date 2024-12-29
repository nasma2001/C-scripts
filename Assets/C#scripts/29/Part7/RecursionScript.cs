using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++) print(FibonacciRecursive(i) + " ");
    }

    int FibonacciRecursive(int n)
    {
        if (n < 2)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
}
