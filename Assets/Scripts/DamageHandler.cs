using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {
    public int damage = 1;

    // a function that is automatically called when
    // something with a Rigidbody2D enters this trigger
    void OnTriggerEnter2D(Collider2D activator) {
        // does the activating thing have a Killable script on it?
        if (activator.GetComponent<Killable>() != null) {
            activator.GetComponent<Killable>().Hurt(damage);
        }
        // destory the bullet anyway
        Destroy(gameObject);
    }


    /*
        // a function that is automatically called when
        // AS LONG AS a thing stays in the trigger, each frame
        void OnTriggerStay2D(Collider2D activator) {
            // does the activating thing have a Killable script on it?
            if (activator.GetComponent<Killable>() != null) {
                activator.GetComponent<Killable>().Hurt(damage);
            }
        }

    */
}
