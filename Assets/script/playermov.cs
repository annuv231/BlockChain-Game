using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0, 10, 200);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 20);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -20);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-10, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(10, 0, 0);
        }
       if (Input.GetKey("space"))
        {
            rb.AddForce(0, 10, 0);
        }
        
        if(rb.position.y< -1f)
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
