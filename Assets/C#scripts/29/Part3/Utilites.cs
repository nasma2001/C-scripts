using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using UnityEngine;

namespace Ass29
{
    public static class Utilites
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        public static string RepeatString(this string string1, int repeat)
        {
            string baseString = "";
            int counter = 1;
            while(counter<=repeat){
                baseString += string1;
                counter++;
            }
            return baseString;
        }
    }
}