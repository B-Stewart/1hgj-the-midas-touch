using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{

    public float Speed = 1.0f;
    public Vector3 Direction;

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * Speed * Direction;
    }
}
