using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass27{
public class MyScript : MonoBehaviour
{
    void Start()
    {
        int num1 = 5;
        int num2 = 1;
        int num3;

        EditNum(num1);
        Debug.Log("Edited number :"+num1);

        EditNumByRef(ref num2);
        Debug.Log("Edited number by reference :"+num2);

        EditNumByOut(out num3);
        Debug.Log("Edited number using Out :"+num3);


    }

   
    void EditNum(int num){
        num += 10;
    }

    void EditNumByRef(ref int num){
        num += 10;
    }

    void EditNumByOut(out int num){
        num = 5;
    }
}}
