using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDaño : MonoBehaviour
{
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
        --collision.gameObject.GetComponent<enemyHealth>().vidas;
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }

}
