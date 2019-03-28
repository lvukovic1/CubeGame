using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1500f;
    public float leftForce = -500f;
    public float rightForce = 500f;
    public float upForce = 2000f;


    // Use this for initialization
    void Start () {
        //rb.AddForce(0, 200, 500);
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(leftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if(rb.position.y < 1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
