//Egg Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    //a check so that only one point is added at a time
    private bool collected;
    public AudioSource chicken_quark_01;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //egg is destroyed on collection
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            chicken_quark_01.Play();
            Destroy(gameObject);
            //prevents multiple points to be added due to frame mistimings
            if (collected == false)
            {
                Score.instance.AddPoint();
                collected = true;
            }
            else
                return;
        }
    }
}
