using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScriptAmbient : MonoBehaviour {

    public AudioClip audioClip;
    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
