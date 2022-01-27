using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiayerMove : MonoBehaviour
{
    public Rigidbody rb;
    //private bool test;
    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5);

        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0);
        }


        if (Input.GetKey(KeyCode.Space))
           
        {
            rb.AddForce(0, 15, 0);

               

        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 0);

        }

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 4, 0);

        }
    }
    void OnCollisionStay(Collision hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {

            transform.position = new Vector3(0, 4, 0);
        }



        if (hit.gameObject.tag == "Ground")
        {





        }





        if (hit.gameObject.tag == "Goal")
        {




        }

    }
}
       

