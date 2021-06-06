using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    public GameObject skyPrefab; 
    public float movementSpeed = -0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * movementSpeed * 0.5f * Time.deltaTime;
    }
}
