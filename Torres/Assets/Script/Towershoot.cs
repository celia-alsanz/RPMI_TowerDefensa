using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towershoot : MonoBehaviour
{
    public GameObject bulletShoot;
    public GameObject enemigo;
    public float height;
    public float ratio;
    public float frecuenciaDisparo;
 
    // Start is called before the first frame update
    void Start()
    {//Cada segundo intenta disparar
        InvokeRepeating("Disparo", 3, 1);
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
    private void Disparo()
    {
       
        {//crea bala
            GameObject bala = Instantiate(bulletShoot, transform.position + new Vector3(0, height, 0), Quaternion.identity);
            //objetivo
            bala.GetComponent<bulletMovement>().enemigo = enemigo;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hola");
        if (other.CompareTag("Enemy")) 
        {
            enemigo = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        enemigo = null;
    }
}
