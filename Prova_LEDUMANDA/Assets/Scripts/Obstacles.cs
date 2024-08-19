using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] float speedPipeMove;

    float leftEdge;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position += Vector3.left * speedPipeMove * Time.deltaTime;
    }
}
