//Crear las variables necesarias para ingresar por Inspector el precio de 3
//productos y un monto de dinero disponible.Comunicar si la suma de los mismos 
//supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public float precio1, precio2, precio3, dinero_disoponible;
    float ptotal;
    
    void Start()
    {

        ptotal = precio1 + precio2 + precio3;
        if (ptotal <= dinero_disoponible)
        {
            Debug.Log ("Tenes dinero suficiente y te sobran $" + (dinero_disoponible - ptotal));
        }

        else
        {
            Debug.Log("Te faltan $" + (ptotal - dinero_disoponible));
        }
    }

    
    void Update()
    {
        
    }
}
