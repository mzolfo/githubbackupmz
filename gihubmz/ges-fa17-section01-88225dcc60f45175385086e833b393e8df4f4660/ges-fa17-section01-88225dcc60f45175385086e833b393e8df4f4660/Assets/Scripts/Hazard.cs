using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour {

    // Use this for initialization

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Checkpoint.playerSpawnPoint == null)
            {
                //what does death really mean in this kind of a game
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                collision.gameObject.transform.position = Checkpoint.playerSpawnPoint.position;
            }
        }
    }


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
