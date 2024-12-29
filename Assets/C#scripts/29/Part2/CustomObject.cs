using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices.WindowsRuntime;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class CustomObject
{

   
   
    private int id;
    private string name;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public CustomObject(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public override string ToString() => $"Object [ID : {Id}, Name : {Name}]";

    // public override bool Equals(object obj)
    // {
    //     CustomObject custom = obj as CustomObject;
    //     bool firstCheck = this.Id == custom.Id;
    //     bool secondCheck = this.Name == custom.Name;

    //     return firstCheck && secondCheck;
    // }

    public static bool operator ==(CustomObject obj1,CustomObject obj2){
        bool firstCheck = obj1.Id == obj2.Id;
        bool secondCheck = obj1.Name == obj2.Name;

        return firstCheck && secondCheck;
    }
    public static bool operator !=(CustomObject obj1,CustomObject obj2){
        

        return !(obj1 == obj2);
    }

}
