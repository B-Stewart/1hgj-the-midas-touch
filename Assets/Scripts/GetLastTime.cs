using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLastTime : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        GetComponent<Text>().text = GameInformation.Time.ToString("F0");
	}
}
