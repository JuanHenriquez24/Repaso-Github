using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej06 : MonoBehaviour
{
    //6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
    //en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
    //par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter %.

    public int num1;
	// Use this for initialization
	void Start () {
		if (num1 > 0)
        {
            if (num1 % 2 == 0)
            {
                Debug.Log("Su numero es par");
            }
            else
            {
              Debug.Log("Su numero es impar");
            }
        }
        else
        {
            Debug.Log("Introduzca un numero mayor a 0");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
