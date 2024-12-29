using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Ass29
{
    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            //part1 section1
            var num = 5;
            var isEven = num % 2 == 0 ? true : false;
            var name = isEven ? $"The number {num} is even" : $"The number {num} is Odd";
            Debug.Log(name);

            //part1 section2
            //ToShort() to cut the time from the date as it expected return date and time
            Debug.Log("The Date : " + DateTime.Now.Date.ToShortDateString());

            // this DateTime.Now.TimeOfDay will return ms too
            Debug.Log("The Time : " + DateTime.Now.TimeOfDay);

            //without ms and without seconds
            Debug.Log("The Time : " + DateTime.Now.ToString("HH:mm"));

            Debug.Log("The day : " + DateTime.Now.DayOfWeek);





        }


    }
}
