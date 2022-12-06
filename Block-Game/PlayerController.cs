using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    bool canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey("t") && canJump)
        {
            //jump
            rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //when player lands on ground. Can Jump becomes true
        if(collision.gameObject.tag == "Ground")
        {
            canJump = true;
            // Debug.Log("I am working");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        //when player lands on ground. Can Jump becomes true
        if(collision.gameObject.tag == "Ground")
        {
            canJump = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("StartMenu");
            // Debug.Log("I am working 222");
        }
    }
    

}
