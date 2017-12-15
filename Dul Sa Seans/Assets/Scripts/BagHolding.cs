using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagHolding : MonoBehaviour {

    public GameObject bag;
    public GameUI gameUI;
    public AudioClip coinDrop;
    private AudioSource bagSoundEffects;

	// Use this for initialization
	void Start () {
        bagSoundEffects = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            gameUI.increaseScore(15);
            Destroy(other.gameObject);
            bagSoundEffects.PlayOneShot(coinDrop);
        }
        if (other.tag == "Goblet")
        {
            gameUI.increaseScore(150);
            Destroy(other.gameObject);
            bagSoundEffects.PlayOneShot(coinDrop);
        }
    }
}
