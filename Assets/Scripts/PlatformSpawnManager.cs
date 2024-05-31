using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public PlatformController platformScript;
    public Transform referencePoint;
    float minY = -4.0f;
    float maxY = 4.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn Platforms", 1.0f, 1.0f);
        platformScript = GameObject.Find("Platform").GetComponent<PlatformController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlatforms()
    {
        Instantiate(platformPrefab, new Vector3(4.5f,Random.Range(minY,maxY)), Quaternion.identity);
    }
}
