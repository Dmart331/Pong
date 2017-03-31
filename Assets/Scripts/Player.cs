using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer { Left, Right }
public class Player : MonoBehaviour
{
    public Rigidbody rb3D;
    public Vector3 initialImpulse;
    public float speed = 15f;





    public ePlayer player;
    private void Start()
    {
        rb3D = GetComponent<Rigidbody>();
        rb3D.AddForce(initialImpulse, ForceMode.Impulse);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Setting the speed of the movment of the player. 
        float inputSpeed = 0f;
        float speed = 10f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("PlayerRight");
        }
        // Move the thing
        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
    }

}
