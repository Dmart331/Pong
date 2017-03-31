using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector3 initialImpulse;
    public Vector3 negitiveImpulse;
    public Vector3 ballStop;
    public float speed = 15f;
    public float test = 15f;
    public Rigidbody rb3D;
    // Use this for initialization
    void Start () {
        rb3D = GetComponent<Rigidbody>();
        rb3D.AddForce(initialImpulse, ForceMode.Impulse);
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        float speed = 10f;
        float test = 0f;
 
            if (Input.GetKeyDown("return"))
        {
            rb3D.isKinematic = true;
            rb3D.constraints = RigidbodyConstraints.None;
            test = Input.GetAxisRaw("PlayerLeft");
            transform.position += new Vector3(0f, 0f, speed * test * Time.deltaTime);
        }
            if (Input.GetKeyUp("return")){
            rb3D.isKinematic = false;
            rb3D.AddForce(negitiveImpulse, ForceMode.Impulse);
            
            
        }


        if (Input.GetKeyDown("tab"))
        {
            test = Input.GetAxisRaw("PlayerRight");
            rb3D.isKinematic = true;
            transform.position += new Vector3(0f, 0f, speed * test * Time.deltaTime);
        }
        if (Input.GetKeyUp("tab"))
        {
            rb3D.isKinematic = false;
            rb3D.AddForce(initialImpulse, ForceMode.Impulse);
        }
    }
}


