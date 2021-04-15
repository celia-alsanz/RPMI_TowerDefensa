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
        // Movimiento de la bala en el eje Y según la velocidad especificada
       transform.position= Vector3.MoveTowards(transform.position, enemigo.transform.position, bulletSpeed);   
       

    }

  
        
    
}
