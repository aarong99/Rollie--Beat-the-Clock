using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 70f;
    public float upwardsForce = 30f;

    // Update is called once per frame
    void FixedUpdate () {

        if (Input.GetKey("w"))

        {   //adds force forwards

            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        }

        if (Input.GetKey("s"))

        {   //adds force backwards

            rb.AddForce(0, 0, -20 * Time.deltaTime, ForceMode.VelocityChange);

        }

        if (Input.GetKey("d"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }   //adds force to the right

        if (Input.GetKey("a"))

        {   //adds force to the left

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        } 

        //reset player position if player is below -3 on the y axis
        if (rb.position.y < -1.5f)

        {

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
