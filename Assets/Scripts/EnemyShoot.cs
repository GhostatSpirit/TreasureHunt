using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    public Transform bulletStartTransform;
    public AudioSource shootSound;

    float cooldownTimer = 0;
    //  Vector3 lastFramePos = new Vector3(0f, 0f, 0f);

    // Update is called once per frame
    void Update() {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0) {
            //Debug.Log("Pew!");
            cooldownTimer = fireDelay;

            GameObject bulletGO = (GameObject) Instantiate(bulletPrefab, bulletStartTransform.position, transform.rotation);
            bulletGO.layer = gameObject.layer;

            // Play the sound for the shot

            //shootSound.Play();
            // possible problem with Play(): it restarts the sound if already playing
            shootSound.PlayOneShot(shootSound.clip);

        }
    }
}
