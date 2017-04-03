using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector3 initialImpulse;
    public Vector3 negitiveImpulse;
    public Rigidbody rb3D;
    private bool isInPlayerTrigger = false;
    private bool isStopped = false;
    private string player;

    // Use this for initialization
    void Start () {
        rb3D = GetComponent<Rigidbody>();
        rb3D.AddForce(initialImpulse, ForceMode.Impulse);
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("return")){
            player = "left";
            if (isInPlayerTrigger && player == "left") {
                rb3D.isKinematic = true;
                rb3D.transform.parent = GameObject.Find("PlayerLeft").transform;
            }
        }

        if (Input.GetKeyUp("return") && isStopped)
        {
            rb3D.isKinematic = false;
            rb3D.transform.parent = null;
            rb3D.AddForce(negitiveImpulse, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("tab"))
        {
            player = "right";
            if (isInPlayerTrigger && player == "right")
            {
                rb3D.isKinematic = true;
                rb3D.transform.parent = GameObject.Find("PlayerRight").transform;
            }
        }

        if (Input.GetKeyUp("tab") && isStopped)
        {
            rb3D.isKinematic = false;
            rb3D.transform.parent = null;
            rb3D.AddForce(initialImpulse, ForceMode.Impulse);
        }


    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

            //Stop moving
        isInPlayerTrigger = true;
        isStopped = true;

    }

    private void OnTriggerExit(Collider other)
    {
        isInPlayerTrigger = false;
        isStopped = false;
    }

}


