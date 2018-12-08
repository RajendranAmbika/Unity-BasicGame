using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

	// Use this for initialization
	void Start () {

       // rb.AddForce(0, 200, 500);
	}
	
	// Update is called once per frame
	
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
         }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }

    }
}
