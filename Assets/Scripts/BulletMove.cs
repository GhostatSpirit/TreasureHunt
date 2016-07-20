using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public float maxSpeed = 5f;
    public Vector3 originalSpeed = new Vector3(0f,0f,0f);

    GameObject playerObject;
	
    void Start() {
        playerObject = GameObject.FindWithTag("Player");
    }
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * velocity + originalSpeed * Time.deltaTime;

        transform.position = pos;

        // if the bullet is far away from the player,
        // destroy it
        float distanceFromPlayer = (playerObject.transform.position - transform.position).magnitude;
        if (distanceFromPlayer > 10) {
            Destroy(this.gameObject);
        }
	}
}
