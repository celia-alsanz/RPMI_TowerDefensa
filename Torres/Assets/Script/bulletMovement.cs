using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    [Tooltip("Velocidad de la bala")]
    public float bulletSpeed;
    public GameObject enemigo;
    void Start()
    {
        // La bala se destruirá a los 3 segundos para evitar problemas de memoria
        Destroy(gameObject, 3);
    }

    void Update()
    {
        if (enemigo != null)
        {
            // Movimiento de la bala hacia el enemigo
            transform.position = Vector3.MoveTowards(transform.position, enemigo.transform.position, bulletSpeed);
        }
        else
        {
            Destroy(gameObject);
        }
         
       

    }

  
        
    
}
