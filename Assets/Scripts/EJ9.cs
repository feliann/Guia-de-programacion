using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

public class EJ9 : MonoBehaviour
{
    // Start is called before the first frame update
    public float precio1;
    public float precio2;
    public float precio3;
    void Start()
    {
        float porcentaje = (precio1 + precio2 + precio3) / 100;
        precio1 = precio1 / porcentaje;
        Debug.Log(precio1+"es el "+ precio1)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
