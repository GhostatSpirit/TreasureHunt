using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using System;

public class Player : MonoBehaviour {

	public Text message;
	public float moveSpeed = 10f;
	[HideInInspector] public static Vector3 startPos;

    Vector2 moveVector;
    Rigidbody2D myRigidbody;

    int direction;
    float localScale_x;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
        direction = 1;

        myRigidbody = GetComponent<Rigidbody2D>();
        localScale_x = transform.localScale.x;


    }
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moveVector = new Vector2(horizontal, vertical);

        // "normalization"
        //moveVector /= moveVector.magnitude;     // manual normalization
        //moveVector = moveVector.normalized;     // better way of normalization ("normalized is a property")
        if (moveVector.magnitude > 1f) {
            moveVector.Normalize();               // alternate better way of normalization
        }

        if (myRigidbody.velocity.x < 0) {
            Debug.Log("Moving left - " + myRigidbody.velocity.x);
            if (direction == 1) {
                transform.localScale = new Vector2(-localScale_x, transform.localScale.y);
                direction = -1;
            }
        } else if (GetComponent<Rigidbody2D>().velocity.x > 0) {
            Debug.Log("Moving right - " + myRigidbody.velocity.x);
            if (direction == -1) {
                transform.localScale = new Vector2(localScale_x, transform.localScale.y);
                direction = 1;
            }
        } 

    }

    void FixedUpdate() {
        myRigidbody.velocity = moveVector * moveSpeed * Time.deltaTime;
        // myRigidbody.velocity = new Vector2(0f, 0f);
        // myRigidbody.velocity = Vector2.zero; // shortcut for the line above

    }

}
