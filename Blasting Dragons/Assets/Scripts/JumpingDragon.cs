using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingDragon : MonoBehaviour
{
    public Vector2 JumpForce;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
            GetComponent<AudioSource>().Play();
        }
    }

    void OnCollide() 
    {
        gameManager.PlayerDied();
    }
}
