using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float flapForce = 5.0f;
    public KeyCode flapButton = KeyCode.Space;
    public float maxHeight = 4.65f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flapButton)) 
        {
            rb2d.AddForce(transform.up * flapForce, ForceMode2D.Impulse);
        }
    }
}
