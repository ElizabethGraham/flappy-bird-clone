using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectPrefab;
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public int amountToPool = 2;
    public float xOffset = 10.24f;
    public float xPos = -10.24f; 
    public float yPos = -4;

    void Awake() 
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
            tmp.SetActive(true);
            pooledObjects.Add(tmp);

            xPos += xOffset;
        }
    }

    public GameObject GetPooledObject() 
    { 
        for(int i = 0; i < amountToPool; i++) 
        { 
            if(!pooledObjects[i].activeInHierarchy) 
            { 
                return pooledObjects[i]; 
            } 
        }
        return null;
    }
}
