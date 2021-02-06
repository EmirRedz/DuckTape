using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour {

    // Use this for initialization
    public GameObject uiObject;
	void Start ()
    {
    //    uiObject.SetActive == false;
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider player)
    {
      //  if (player.gameObject.tag == "Player")
        //{
         //   uiObject.SetActive == true;
        //}
    }
    void Update ()
    {
	
	}
}
