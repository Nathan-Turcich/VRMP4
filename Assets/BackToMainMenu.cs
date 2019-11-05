using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(0);
        }
    }
}
