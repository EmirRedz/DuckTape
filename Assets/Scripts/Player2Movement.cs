using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {

    
    public float speed;
    private Rigidbody rb;
    public Rigidbody door;
    public int forceConst = 50;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal1 = Input.GetAxis("Horizontal1");
        float moveVertical1 = Input.GetAxis("Vertical1");

        Vector3 movement = new Vector3(moveHorizontal1, 0.0f, moveVertical1);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("R"))
        {
            door.useGravity = true;
            door.isKinematic = false;
            door.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

}

