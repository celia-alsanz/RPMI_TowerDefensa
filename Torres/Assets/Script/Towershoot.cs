using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towershoot : MonoBehaviour
{
    public GameObject bulletShoot;
    public GameObject enemigo;
    public float height;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject bala= Instantiate(bulletShoot, transform.position+ new Vector3(0,height,0), Quaternion.identity);
            bala.GetComponent<bulletMovement>().enemigo= enemigo;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
}
