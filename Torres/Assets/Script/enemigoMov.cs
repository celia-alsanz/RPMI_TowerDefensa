using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigoMov : MonoBehaviour
{
    public NavMeshAgent agent;
   
   public Vector3 position;
   
    // Start is called before the first frame update
    void Start()
    {
        
        agent.SetDestination(position);
    }
  
}


