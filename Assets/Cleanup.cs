using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanup : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D col)
    {
        //col.gameObject.SetActive(false);
        col.gameObject.transform.position.Set(10.24f, -2, 0);
        if (col.gameObject.tag == "Obstacles")
        {
            col.gameObject.transform.position.Set(10.24f, -2, 0);
        }
    }
}
