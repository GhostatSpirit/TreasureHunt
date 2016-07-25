using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public int sceneNumber = 0;
    public KeyCode keycode = KeyCode.Space;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keycode)) {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
