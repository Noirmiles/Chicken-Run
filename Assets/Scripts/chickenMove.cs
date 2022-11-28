//Movement Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenMove : MonoBehaviour
{
    public float speed = 40f;
    public float mouseSpeed = 10f;
    public Rigidbody rb;
    public bool onGround = true;
    public bool playerMove = true;
    private Animator anim;
    public AudioSource Dog_big_woof_05;
    public AudioSource chicken_starlled_03;
    public AudioSource chicken_starlled_01;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
        transform.Translate(0f, 0f, -0.5f);
    }

    //float mx;

    // Update is called once per frame
    void Update()
    {
        if(playerMove==true)
        {
            //z-direction force is constantly applied, but player is free to move left and right
            transform.Translate(0f, 0f, -0.5f);

            if (Input.GetKey("a"))
            {
                this.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                this.transform.Translate(-Vector3.right * speed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
            {
                chicken_starlled_03.Play();
                rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
                onGround = false;
                anim.SetBool("isJumping", true);
            }

            if (Input.anyKey)
            {
                anim.SetBool("isMoving", true);
            }
            else
            {
                anim.SetBool("isMoving", false);
            }
        }
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        //applies a check so that the player must land before another jump is possible
        if(collision.gameObject.tag == "ground")
        {
            onGround = true;
            anim.SetBool("isJumping", false);
        }
        //game ends when hit by fox
        if (collision.gameObject.tag == "fox")
            
        {
            //dog sounds plays and player movement stops when "eaten"
            Dog_big_woof_05.Play();
            playerMove = false;
            anim.SetBool("isDead", true);
            FindObjectOfType<GameManager>().LostGame();
        }
        if (collision.gameObject.tag == "log")

        {
            // player movement stops and game ends when log is hit
            playerMove = false;
            anim.SetBool("isDead", true);
            FindObjectOfType<GameManager>().LostGame();
        }
        if (collision.gameObject.tag == "barn")
            //lets the game know the player has won
        {
            //stops player moving when reach the end and plays victory cluck
            playerMove = false;
            chicken_starlled_01.Play();
            FindObjectOfType<GameManager>().WinGame();
        }
    }
    
}
