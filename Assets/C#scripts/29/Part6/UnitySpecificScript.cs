using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    private GameObject light, joker, targetObject;

    void OnEnable() => print("GameObject Enabled");


    void Start()
    {
        print("Game started!");
        light = FindAnyObjectByType<Light>().gameObject;
        joker = GameObject.FindWithTag("Joker");
        targetObject = GameObject.Find("TargetObject");

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            targetObject.SetActive(false);
            print("TargetObject deactivated!");
        }
        if (targetObject != null) print("Find object by name : " + targetObject.name);
        else Debug.Log("No TargetObject found!!");

        if (joker != null) print("Find object by tag : " + joker.name);
        else print("No Joker object found.");

        if (light != null) print("Find object by type : " + light.name);
        else print("No Light object found.");
    }
    void OnDisable()
    {
        print("GameObject Disabled");
    }




    // 2. GameObject Interaction
    // 1. Use SetActive() to deactivate another GameObject when the "D" key is pressed.

    // Page 8 of 9
    // 2. print() "TargetObject deactivated!" to confirm that the object has been
    // deactivated.
}
