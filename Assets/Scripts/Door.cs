using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject door;
    private Rigidbody rb;   

	// Use this for initialization
    
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

       
        if (Input.GetKey(KeyCode.R))
        {
            door.GetComponent<Rigidbody>().useGravity = true;
            door.GetComponent<Rigidbody>().isKinematic = false;
            door.GetComponent<Collider>().enabled = false;
            
        }
        else
        {

            door.GetComponent<Rigidbody>().isKinematic = true;
        }
        
    }
}
