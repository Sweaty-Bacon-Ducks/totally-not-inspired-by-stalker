using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellBehaviour : MonoBehaviour {

    public Transform ejectTransform;
    public Vector3 velocity;

	// Use this for initialization
	void Start () {
        transform.position = ejectTransform.position;
        transform.rotation = ejectTransform.rotation;
        GetComponent<Rigidbody>().AddForce(velocity);
	}
}
