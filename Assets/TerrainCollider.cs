using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCollider : MonoBehaviour {

    [SerializeField] private GameObject gameOverMenuUI;

    private void OnTriggerEnter(Collider other)
    {
        gameOverMenuUI.SetActive(true);
        GameObject.Find("Plane").GetComponent<AircraftController>().enabled = false;
    }
}
