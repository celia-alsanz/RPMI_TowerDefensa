using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public int vidas;
    public int vidasMax = 10;
    public Slider slider;
    public Transform camara;
    // Start is called before the first frame update
    void Start()
    {
        vidas = vidasMax;
        MaxSalud();
    }
    private void LateUpdate()
    {
        slider.transform.LookAt(transform.position+camara.forward);
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = vidas;

        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
        
    }
    public void MaxSalud()
    {
        slider.maxValue = vidas;
        slider.value = vidas;
       
    }
    public void Lozania()
    {
        slider.value = vidas;
        
    }

}
