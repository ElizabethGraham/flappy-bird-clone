using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject landPrefab;
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public int amountToPool = 2;
    public float offset = -10.24f; 

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
            tmp = Instantiate(landPrefab, new Vector3(offset, -4, 0), Quaternion.identity);
            tmp.SetActive(true);
            pooledObjects.Add(tmp);

            offset += 10.24f;
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
