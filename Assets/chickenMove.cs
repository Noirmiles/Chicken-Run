using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenMove : MonoBehaviour
{
    public float speed = 2f;
    public float mouseSpeed = 5f;
    public Rigidbody rb;
    public bool onGround = true;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    float mx;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            this.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
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
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            onGround = false;
            anim.SetBool("isJumping", true);
        }
        mx += Input.GetAxisRaw("Mouse X") * mouseSpeed;

        this.transform.localRotation = Quaternion.AngleAxis(mx, Vector3.up);

        if (Input.anyKey)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            onGround = true;
            anim.SetBool("isJumping", false);
        }
    }
}
