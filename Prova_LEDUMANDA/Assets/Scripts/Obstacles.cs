using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] float speedPipeMove;

    float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speedPipeMove * Time.deltaTime;

        if (transform.position.x < leftEdge) 
        {
         Destroy(gameObject);
        }
    }
}
