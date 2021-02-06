using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        Vector3 rotate = new Vector3(15, 30, 45);
        transform.Rotate(rotate * Time.deltaTime * 2);
	}
}
