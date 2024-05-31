using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    PlatformController platformScript;

    float minY = -2.0f;
    float maxY = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatforms", 2, 2);
                            //what, when, how often
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPlatforms()
    {
        Instantiate(platformPrefab, new Vector2(4.5f,Random.Range(minY,maxY)), Quaternion.identity);
    }
}
