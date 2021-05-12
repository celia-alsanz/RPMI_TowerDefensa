using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float FrecuenciaEnemigo;
    private float UltimoVezEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InstanciaEnemigo();
    }
    void InstanciaEnemigo()
    {
        if (Time.time - UltimoVezEnemigo >= FrecuenciaEnemigo)
        {
            //variable donde se registra la instancia
            GameObject instanciaEnemigo = Instantiate(enemigoPrefab, transform.position, Quaternion.identity);
            //Registra el momento
            UltimoVezEnemigo = Time.time;
        }
    }
}
