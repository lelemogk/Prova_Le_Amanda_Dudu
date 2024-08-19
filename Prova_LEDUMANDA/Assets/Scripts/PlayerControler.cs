using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviourPun
{
    [SerializeField] float forcaPulo;
    [SerializeField] int score;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        int r = Random.Range(1,1);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * forcaPulo;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.instance.UpdateScore(-score);
        }
        if (collision.gameObject.CompareTag("Score"))
        {
            GameManager.instance.UpdateScore(score);
        }
    } 
}
