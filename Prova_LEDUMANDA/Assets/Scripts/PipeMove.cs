using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float speedPipeMove;

    private void Update()
    {
        transform.position += Vector3.left * speedPipeMove * Time.deltaTime;
    }
}
