using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{

    public Vector3 from;
    public Vector3 to;
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector3.Lerp(from, to, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
