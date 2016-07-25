using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RespawnPlayer : MonoBehaviour {
    Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // try to find the player here
        if (player == null) {
            GameObject go = GameObject.FindWithTag("Player");
            if (go != null) {
                player = go.transform;
            }
        }
        // if found player, try again next frame
        // else, wait for several seconds and restart the scene
        if (player != null) {
            return;
        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
