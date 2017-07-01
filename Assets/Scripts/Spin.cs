using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float Speed = 1.0f; // x Degrees per second?
    public Vector3 Direction; // Axis to rotate around

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Direction * Time.deltaTime * Speed);
    }
}
