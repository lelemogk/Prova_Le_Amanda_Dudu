using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawmManager : MonoBehaviour
{
   [SerializeField] float clock;
   [SerializeField] float cooldown;

    float max = 2, mim = -2;
    [SerializeField]GameObject prefabPipe;

    private void Update()
    {
        if (clock <= 0) 
        {
            clock = cooldown;
            Spawm();
        }
        else 
        {
          clock -= Time.deltaTime;
        }
    }         
    
    void Spawm()
    {
        GameObject newPipe = Instantiate(prefabPipe, transform.position, Quaternion.identity);
        newPipe.transform.position += new Vector3(0, Random.Range(mim, max));
    }
            // Instancia o prefab na posição x correspondente ao limite da tela (lado direito) e em uma posição y aleatória entre -2 e 2.
}

