using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float speed = -3.5f;

    private void Update()
    {
        transform.position = transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
