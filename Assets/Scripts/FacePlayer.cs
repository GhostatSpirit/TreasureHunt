using UnityEngine;
using System.Collections;

public class FacePlayer : MonoBehaviour {

    public float rotateSpeed = 100f;

    Transform player;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        // try to find the player here
	    if(player == null) {
            GameObject go = GameObject.FindWithTag("Player");
            if(go != null) {
                player = go.transform;
            }
        }
        // if cannot find player, try again next frame
        if (player == null)
            return;

        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotateSpeed * Time.deltaTime);
	}
}
