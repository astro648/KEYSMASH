using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVirusForward : MonoBehaviour
{
    public float speed = 40f;
    public Vector3 translationAxis;

    void Update()
    {
        transform.Translate(translationAxis * speed * Time.deltaTime);
    }
}
