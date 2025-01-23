using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyController : MonoBehaviour
{
    Rigidbody character;
    bool isJumping = false;
    Vector3 movement;
    float charcterSpeed = 8f;
    void Start()
    {
        character = GetComponent<Rigidbody>();
        character.freezeRotation = true;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            isJumping = true;

            
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0,
                               -Input.GetAxisRaw("Vertical"));
        movement = movement.normalized * charcterSpeed;
        movement.y = character.velocity.y;

    }
    void FixedUpdate()
    {
        if (isJumping)
        {
            character.AddForce(Vector3.up * 8f, ForceMode.Impulse);
            isJumping = false;
        }
        else
            character.velocity = movement;


        if (character.velocity.y < 0)
            character.AddForce(Vector3.down * 15, ForceMode.Acceleration);

    }
}
