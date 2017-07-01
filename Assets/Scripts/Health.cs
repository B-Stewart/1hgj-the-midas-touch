using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int MaxHealth = 3;
    private AudioSource audioSource;
    public GameObject HitEffect;
    private int CurHealth;
    private CheckEnd checkEnd;

	// Use this for initialization
	void Start ()
    {
        CurHealth = MaxHealth;
        audioSource = this.GetComponent<AudioSource>();
        checkEnd = GameObject.FindGameObjectWithTag("GameController").GetComponent<CheckEnd>();
    }
	
	public void TakeDamage(int damage)
    {
        CurHealth -= damage;
        audioSource.Play();
        Instantiate(HitEffect, this.transform.position, this.transform.rotation, this.transform);

        if (CurHealth == 0)
            OnDead();
    }

    public void OnDead()
    {
        this.checkEnd.DestroyHouse();

        Destroy(this.gameObject, 0.25f);
    }
}
