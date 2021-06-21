using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandController : MonoBehaviour
{
    public GameObject[] landTiles;
    
    public float offscreenXPos = -4.1f;
    public Vector3 respawnPos = new Vector3(16.38f, -4, 0);
    public float movementSpeed = -0.1f;

    void Start()
    {
        landTiles = GameObject.FindGameObjectsWithTag("Land");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject land = ObjectPool.SharedInstance.GetPooledObject();

        landTiles = GameObject.FindGameObjectsWithTag("Land");
        for (int i = 0; i < landTiles.Length; i++)
        {
            landTiles[i].transform.position += transform.right * movementSpeed * 10 * Time.deltaTime;
            landTiles[i].SetActive(true);
            
            if (landTiles[i].transform.position.x <= offscreenXPos)
            {
                landTiles[i].transform.position = respawnPos;
            }
        }
    }
}
