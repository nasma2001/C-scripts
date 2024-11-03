using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTableOfFiveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 10; i++){
            Debug.Log("5 X " + i + " = " + Multiply(5,i));
        }
    }

    int Multiply(int num1, int num2){
        return num1 * num2;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
