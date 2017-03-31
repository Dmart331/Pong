using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector3 initialImpulse;
    public Vector3 negitiveImpulse;
    public Rigidbody rb3D;
    // Use this for initialization
    void Start () {
        rb3D = GetComponent<Rigidbody>();
        rb3D.AddForce(initialImpulse, ForceMode.Impulse);
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
       //Freeze ball functions Below. Return is player right Tab is player left.
            if (Input.GetKeyDown("return"))
        {
            //Stop moving
            rb3D.isKinematic = true;
            //Set parent to capsule
            rb3D.transform.parent = GameObject.Find("PlayerLeft").transform;
        }
            if (Input.GetKeyUp("return")){
            //Carry on
            rb3D.isKinematic = false;
            //Remove the parent
            rb3D.transform.parent = null;
            //Add the force
            rb3D.AddForce(negitiveImpulse, ForceMode.Impulse);
            
            
        }


        if (Input.GetKeyDown("tab"))
        {
            rb3D.isKinematic = true;
            rb3D.transform.parent = GameObject.Find("PlayerRight").transform;
        }
        if (Input.GetKeyUp("tab"))
        {
            rb3D.isKinematic = false;
            rb3D.transform.parent = null;
            rb3D.AddForce(initialImpulse, ForceMode.Impulse);
        }
    }
}


