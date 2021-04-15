using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigoMov : MonoBehaviour
{
    public NavMeshAgent agent;
    int vidas = 3;
   public Vector3 position;
    private void OnCollisionEnter(Collision collision)
    {
        vidas --;
        if (vidas == 0)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        agent.SetDestination(position);
    }
  
}


