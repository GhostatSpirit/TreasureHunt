using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    public Transform bulletStartTransform;
    public AudioSource shootSound;

    float cooldownTimer = 0;
  //  Vector3 lastFramePos = new Vector3(0f, 0f, 0f);
	
	// Update is called once per frame
	void Update () {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && cooldownTimer <= 0) {
            //Debug.Log("Pew!");
            cooldownTimer = fireDelay;

            // Get the difference between the mouse and the player
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - bulletStartTransform.position;
            difference.Normalize();
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            Quaternion bulletRotation = Quaternion.Euler(0f, 0f, rotZ - 90);



            Instantiate(bulletPrefab, bulletStartTransform.position, bulletRotation);


            // Play the sound for the shot

            //shootSound.Play();
            // possible problem with Play(): it restarts the sound if already playing
            shootSound.PlayOneShot(shootSound.clip);

        }
	}
}
