using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int playerScore, diviser;
    void Start()
    {
        playerScore = 100;
        diviser = 0;
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;
        }
        catch (DivideByZeroException exp)
        {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }


    // Expected Unity Console Output
    // Attempting to calculate score multiplier...
    // Error: Division by zero occurred while calculating score multiplier.
    // Score calculation complete. Cleaning up resources.
}
