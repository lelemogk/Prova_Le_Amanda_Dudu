using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerControler : MonoBehaviourPun
{
    [SerializeField] float forcaPulo;

    Rigidbody2D rb;

    UIManager managerUI;
    int health;
    int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      //  int r = Random.Range(1,1);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * forcaPulo;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       if (hit.gameObject.CompareTag("Obstacle") && health > 1)
        {
            health = health - 10;
        }
        else
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        if(score > score)
        {
            // atualizar o recorde do jogador
        }

    }
}
