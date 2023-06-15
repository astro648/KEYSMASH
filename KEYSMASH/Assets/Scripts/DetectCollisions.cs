using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        // Destroy player gameobject, game over
        Destroy(gameObject);
    }
    // Change this in the future to lower player health
}
