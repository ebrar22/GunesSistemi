using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform planet;
    public float rotationSpeed;

    private void Update()
    {
        transform.RotateAround(planet.position, Vector3.up, rotationSpeed * Time.deltaTime);

    }
}   