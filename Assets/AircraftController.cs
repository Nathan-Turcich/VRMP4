using UnityEngine;
using System.Collections;

//https://forum.unity.com/threads/here-is-a-simple-flying-script-that-works.251304/

public class AircraftController : MonoBehaviour
{
    public float forwardThrustForce = 40.0f;

    // Use this for initialization
    void Start()
    {
        //GameObject.Find("Explosion").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkForAccelerationDeceleration();
    
        transform.position += -transform.right * Time.deltaTime * forwardThrustForce;
        if (Input.GetKeyDown(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime * 40.0f;

        transform.Rotate(Input.GetAxis("Horizontal"), 0.0f, -Input.GetAxis("Vertical"));

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if (terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,
            terrainHeightWhereWeAre,
            transform.position.z);
        }
    }

    void checkForAccelerationDeceleration()
    {
        if (Input.GetKeyDown(KeyCode.Period))
        {
            if (forwardThrustForce < 200f)
            {
                forwardThrustForce += 5f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Comma))
        {
            if (forwardThrustForce > 10f)
            {
                forwardThrustForce -= 5f;
            }
        }
    }
}