using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CheckWinCondition : MonoBehaviour {

    public int sceneNumber = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // find the enemy
        GameObject go = GameObject.FindWithTag("Enemy");

        // if we cannot find the enemy any more
        if(go == null) {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
