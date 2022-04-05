using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6 : MonoBehaviour
{
    //6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0 en una variable 
    //llamada num1 y muestre un mensaje por pantalla indicando "el  número es par" o "el número es impar". 
    //Deberá utilizar el operador “módulo” es el caracter  %.

    public int num1;
    
    
    void Start()
    {
        if (num1 < 0)
            Debug.Log("el numero tiene que se mayor a 0");

        else if ((num1 % 2) == 0)
            Debug.Log("Es Par");
        else
            Debug.Log("Es Impar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
