using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject floorCollider;
    public GameObject pillarCollider;

    //Upon collision with Player, this GameObject will reverse direction
    private void OnTriggerEnter(Collider player)
    {
        // Game Over
    }
}
