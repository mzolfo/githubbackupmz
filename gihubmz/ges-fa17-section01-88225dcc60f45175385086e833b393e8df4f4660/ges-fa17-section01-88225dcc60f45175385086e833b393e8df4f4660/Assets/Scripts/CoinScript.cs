using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

    static int coinCount = 0;

   
    Text coinCountText;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

	// Use this for initialization
	void Start () {
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        coinCountText = GameObject.Find("coinTextUI").GetComponent<Text>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            coinCount++;
            Debug.Log("Touched the coin. Coincount: " + coinCount);
            coinCountText.text = "Coins: " + coinCount;
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
