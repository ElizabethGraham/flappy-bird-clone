using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{
    public GameObject[] pillarSets; // The pool of pillars being used in game
    public float xOffset = 6f; 
    public float movementSpeed = -0.25f;
    
    public Vector3 spawnPos = new Vector3(3, 0, 0);
    public float offscreenXPos = -9f;
    public Vector3 respawnPos = new Vector3(15, 0, 0);
    public GameObject pillar;

    void Start()
    {
        pillarSets = GameObject.FindGameObjectsWithTag("Pillar");
    }

    // Update is called once per frame
    void Update()
    {
        pillar = ObjectPool.SharedInstance.GetPooledObject();

        pillarSets = GameObject.FindGameObjectsWithTag("Pillar");
        for (int i = 0; i < pillarSets.Length; i++)
        {
            pillarSets[i].transform.position += transform.right * movementSpeed * 10 * Time.deltaTime;
            pillarSets[i].SetActive(true);
            
            if (pillarSets[i].transform.position.x <= offscreenXPos)
            {
                pillarSets[i].transform.position = respawnPos;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        col.gameObject.transform.position.Set(10.24f, -2, 0);
        if (col.gameObject.tag == "Cleanup")
        {
            transform.position.Set(10.24f, -2, 0);
        }
    }
}
