using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xBound = 50;
    private float yBound = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y > yBound)
        {
            Destroy(gameObject);
        }
    }
}
