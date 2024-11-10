using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Fireball : MonoBehaviour
{
    public Vector2 fireVelocity;
    private AudioSource onDestroySound;

    public GameObject onCollisionEffect;

    public int points = 10; // Points for defeating this enemy
    private ScoreManager scoreManager; // Reference to ScoreManager


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = fireVelocity;
        Destroy(gameObject, 1.9f);
        scoreManager = FindObjectOfType<ScoreManager>();
        
        if (!TryGetComponent(out onDestroySound))
        {
            onDestroySound = gameObject.AddComponent<AudioSource>();
        }

        onDestroySound.playOnAwake = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Instantiate(onCollisionEffect, transform.position, transform.rotation);

        scoreManager.AddScore(points);
        Destroy(gameObject); 
    }

     
}