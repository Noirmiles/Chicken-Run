//Fox Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public Rigidbody rbfox;
    // Start is called before the first frame update
    void Start()
    {
        //starts the movement of the fox
        transform.Translate(0f, 0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //continously makes the fox move
        transform.Translate(0f, 0f, 1.5f);
    }
    //has the game delete the fox when it reaches the end so that memory isn't cluttered
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "despawn")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fox")
        {
            Destroy(gameObject);
        }
    }
}
