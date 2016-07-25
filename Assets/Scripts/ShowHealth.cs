using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour {
    Transform player;
    Text message;

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

        int currentHP = player.GetComponent<Killable>().currentHealth;

        message = GetComponent<Text>();

        message.text = "Health: " + currentHP.ToString();

    }
}
