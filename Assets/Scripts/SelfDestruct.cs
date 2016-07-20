using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

    GameObject playerObject;


    void Start() {
        playerObject = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D activator) {
        Destroy(this.gameObject);
    }

    void Update() {
        // if the bullet is far away from the player,
        // destroy it
        float distanceFromPlayer = (playerObject.transform.position - transform.position).magnitude;
        if (distanceFromPlayer > 10) {
            Destroy(this.gameObject);
        }
    }
}
