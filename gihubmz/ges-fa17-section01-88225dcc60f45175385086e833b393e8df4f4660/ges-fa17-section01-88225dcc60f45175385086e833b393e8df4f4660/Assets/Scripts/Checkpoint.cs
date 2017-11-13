using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    [SerializeField]
    private float activatedScale;

    [SerializeField]
    private float deactivatedScale;

    [SerializeField]
    private Color activatedColor;

    [SerializeField]
    private Color deactivatedColor;

   public static Transform playerSpawnPoint;

    private bool isActive = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = deactivatedColor;
        transform.localScale *= deactivatedScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isActive)
        {
            ActivateCheckpoint();
        }
            
    }

    private void deactivateCheckpoint()
    {
       
        isActive = false;
        transform.localScale = transform.localScale * deactivatedScale;
        spriteRenderer.color = deactivatedColor;
    }

    private void ActivateCheckpoint()
    {
        playerSpawnPoint = gameObject.transform;
        isActive = true;
        transform.localScale = transform.localScale * activatedScale;
        spriteRenderer.color = activatedColor;
    }

}
