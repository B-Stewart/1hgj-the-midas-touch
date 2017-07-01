using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToGoldOnClick : MonoBehaviour {

    SpriteRenderer sprite;
    Color gold = new Color(255, 255, 0, 150);
    public bool isGold = false;

    // Use this for initialization
    void Start ()
    {
        sprite = GetComponent<SpriteRenderer>();
	}

    private void OnMouseDown()
    {
        this.sprite.color = this.gold;
        this.isGold = true;
    }
}
