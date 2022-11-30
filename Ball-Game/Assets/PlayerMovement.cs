using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour //unity scrips extend Monobehavous
{
    // Start is called before the first frame update
    //Method executed once they start game and only once
    // Instantiate variable rb of type Rigidbody
    //camelCase convention for variables
    Rigidbody rb;
    // [SerializeField] makes it available to the unity editor so that we can edit it there
    // Can also use public: Other Scripts can access this variable
    [SerializeField]float jumpForce = 5f;
    [SerializeField]float movementSpeed = 6f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    // Camera Follows Players by dragging and dropping it into the player object
    // Making the player nest it into the hierachy
    // Update is called once per frame
    void Update()
    {
        // Using ProjectSettings -> inputmangaer
        float horizontalMove = Input.GetAxis("Horizontal"); 
        float verticalMove = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalMove * movementSpeed, rb.velocity.y, verticalMove * movementSpeed);
        if (Input.GetButtonDown("Jump"))//returns true if space is pressed
        {
            //Vector3 holds x, y, z inputs
            rb.velocity = new Vector3(rb.velocity.x,jumpForce,rb.velocity.z);
        }
       

    }

    void UsingDefaultKeys()
    {
        /* // USING NORMAL KEYBOARD KEYS
        //  Used for debugging
        // Debug.Log("Hello from Start");
        // Press down the key
        if (Input.GetKeyDown("space"))//returns true if space is pressed
        {
            //Vector3 holds x, y, z inputs
            rb.velocity = new Vector3(0,5f,0);
        }
        if(Input.GetKey("t"))
        {
            //Move Forward and move along the Z-Values
            rb.velocity = new Vector3(0,0,5f);
            // Debug.Log("The Up Key is working");
        }
        if(Input.GetKey("right"))
        {
            //Move Forward and move along the X-Values
            // Freeze Rotations in all directions on the floor board under the RigidBody -> Constraints
            rb.velocity = new Vector3(5f,0,0);
        }
        if(Input.GetKey("down"))
        {
            //Move Forward and move along the Z-Values
            rb.velocity = new Vector3(0,0,-5f);
        }
        if(Input.GetKey("left"))
        {
            //Move Forward and move along the Z-Values
            rb.velocity = new Vector3(-5f,0,0);
        }
        */
    }
}
