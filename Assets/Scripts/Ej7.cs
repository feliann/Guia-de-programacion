using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y 
////En caso de igualdad entre los tres imprimir &quot;Los números son iguales&quot;. Test1: num1 =
//12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1 Test2: num1

//= 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num /1
//Test3: num1 = 3, num2 = 10, num3= 28. Resultado esperado: El mayor número es num3
//Test4: num1 = 5, num2 = 5, num3= 5. Resultado esperado: Los números son iguales

public class Ej7 : MonoBehaviour
{
    // Start is called before the first frame update

        public int num1;
        public int num2;
        public int num3;
    void Start()
    {
        if (num1 < num2)
        {
            if (num2 < num3)
            {
                Debug.Log(num3 + "es el mayor");
            }
            else
                Debug.Log(num2 + "es el mayor");
        }
        else if (num1 > num2)
        {
            if (num1 < num3)
            {
                Debug.Log(num3 + "es el mayor");
            }
            else
                Debug.Log(num1 + "es el mayor");
            }
        else
        {
           Debug.Log ("los tres son iguales");
        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
