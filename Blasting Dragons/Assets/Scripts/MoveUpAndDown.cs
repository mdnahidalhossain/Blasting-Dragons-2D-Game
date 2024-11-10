using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    private float height = 1.2f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * Mathf.Sin(Time.time) * height;
    }
}
