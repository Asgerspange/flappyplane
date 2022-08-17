using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] float moveSpeed = 2;

    void Update()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }
}
