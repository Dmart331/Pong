using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector3 initialImpulse;
    public Vector3 negitiveImpulse;
    public Rigidbody rb3D;
    private bool isInPlayerTrigger = false;
    private bool isStopped = false;

    // Use this for initialization
    void Start () {
        rb3D = GetComponent<Rigidbody>();
        rb3D.AddForce(initialImpulse, ForceMode.Impulse);
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("return")){
            if (isInPlayerTrigger && GameObject.Find("PlayerLeft")) {

                stopMoving();

                rb3D.transform.parent = GameObject.Find("PlayerLeft").transform;
            }
        }

        if (Input.GetKeyUp("return") && isStopped)
        {
            startMoving();
            rb3D.AddForce(negitiveImpulse, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("tab"))
        {
            if (isInPlayerTrigger && GameObject.Find("PlayerRight"))
            {
                stopMoving();

                rb3D.transform.parent = GameObject.Find("PlayerRight").transform;
            }
        }

        if (Input.GetKeyUp("tab") && isStopped)
        {
            startMoving();
            rb3D.AddForce(initialImpulse, ForceMode.Impulse);
        }


    }

    private void stopMoving()
    {
        rb3D.isKinematic = true;
        isStopped = true;
    }

    private void startMoving()
    {
        rb3D.isKinematic = false;
        rb3D.transform.parent = null;
        isStopped = false;
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

            //Stop moving
        isInPlayerTrigger = true;

    }

    private void OnTriggerExit(Collider other)
    {
        isInPlayerTrigger = false;
    }

}


