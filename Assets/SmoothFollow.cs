using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {
    public Transform target;
    Vector3 distance;
	void Start () {
	    distance = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position = target.position + distance;
	}
}
