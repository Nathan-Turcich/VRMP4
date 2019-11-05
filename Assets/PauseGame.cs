using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=pbeB9NsaoPs

public class PauseGame : MonoBehaviour {

    [SerializeField] public GameObject pauseMenuUI;
    [SerializeField] public bool isPaused;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isPaused)
            {
                Time.timeScale = 1.0f;
                AudioListener.pause = false;
                pauseMenuUI.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                AudioListener.pause = true;
                pauseMenuUI.SetActive(true);
            }
            isPaused = !isPaused;
        }
    }
}
