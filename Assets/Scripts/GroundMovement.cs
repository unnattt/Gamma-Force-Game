using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float _groundSpeed;

    void Update()
    {
        transform.Translate(Vector2.left * _groundSpeed * Time.deltaTime);
    }
}
