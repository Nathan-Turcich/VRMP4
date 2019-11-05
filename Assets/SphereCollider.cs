using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereCollider : MonoBehaviour {

    public Text text;
    public static int score;
    public GameObject sphere;
    public GameObject plane;

	// Use this for initialization
	void Start () {
        plane = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update () {
        text.text = "Current Score\n" + score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (sphere.GetComponent<Renderer>().enabled)
        {
            score++;
            sphere.GetComponent<Renderer>().enabled = false;
            Invoke("deactivateSphere", 5);
        }
        
    }

    void deactivateSphere()
    {
        sphere.GetComponent<Renderer>().enabled = true;
    }
}
