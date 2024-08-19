using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawmManager : MonoBehaviour
{
    float clock;
    float cooldown;

    GameObject prefabPipe;

    private void Update()
    {
        if (clock <= 0) 
        {
            clock = cooldown;
            Instantiate(prefabPipe, new Vector3(), quaternion.identity);
        }
        else 
        {
          clock -= Time.deltaTime;
        }
    }            
            // Instancia o prefab na posi��o x correspondente ao limite da tela (lado direito) e em uma posi��o y aleat�ria entre -2 e 2.
}

