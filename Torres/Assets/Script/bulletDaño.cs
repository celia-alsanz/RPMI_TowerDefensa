using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDaño : MonoBehaviour
{
    public int Daño;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        collision.gameObject.GetComponent<enemyHealth>().vidas-=Daño;
       
        //Los parentesis donde sale daño hacen referencia al valor de la funcion de enemy health, que ahí la he llemado damage.
       // collision.gameObject.GetComponent<enemyHealth>().HacerDaño(Daño);
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }

}
