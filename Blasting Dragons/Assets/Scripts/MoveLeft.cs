using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 2;
    private Enemy enemyRed;


    private void Awake()
    {
        enemyRed = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime, Space.World);

        if (transform.position.x <= -17.7)
        {
            transform.position += new Vector3(35.4f, 0, 0);
            ShowRandomSprite();
            enemyRed?.Respawn();
        }
    }

    private void ShowRandomSprite()
    {
        int index = Random.Range(0, 4);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;
            child.gameObject.SetActive(shouldShow);
        }
    }

    // private void OnEnable()
    // {
    //     // enemy = GetComponent<Enemy>();
    //     ShowRandomSprite();
    // }
}
