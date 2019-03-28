using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovment movement;
    

     void OnCollisionEnter(Collision collision)
    {

        if(collision.collider.tag == "Cube")
        {
            movement.enabled = false;


            FindObjectOfType<GameManager>().EndGame();
        }
        //FindObjectOfType<GameManager>().EndGame();
    }
}
