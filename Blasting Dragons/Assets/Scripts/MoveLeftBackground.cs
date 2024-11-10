using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftBackground : MonoBehaviour
{
    public float backgroundSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * backgroundSpeed * Time.deltaTime);

        if (transform.position.x <= -17.7)
        {
            transform.position += new Vector3(35.4f, 0, 0);
        }
    }

}
