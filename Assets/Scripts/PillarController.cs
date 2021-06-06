using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{
    public GameObject pillarPrefab;
    public float movementSpeed = -0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pillarPrefab.transform.position += transform.right * movementSpeed * 10 * Time.deltaTime;
    }
}
