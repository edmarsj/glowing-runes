using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
    private void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
        
        var sinMovement = Mathf.Sin(Time.time) * .25f;
        transform.position = startPosition + Vector3.up * sinMovement;
    }
}
