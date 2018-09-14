using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public int rotationAngle;

    private Transform cubeTransform;

    // Use this for initialization
    void Start () {
        cubeTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        cubeTransform.Rotate(Vector3.up, rotationAngle * Time.deltaTime);
	}
}
