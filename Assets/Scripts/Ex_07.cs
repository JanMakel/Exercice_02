using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07 : MonoBehaviour
{
    //Variables
    public string operation;
    public float num1;
    public float num2;

    private void Start()
    {
        //You can change de operation of the diferents nums if you put the 4 key words
        if(operation == "sum")
        {
            Debug.Log($"{num1} + {num2} = {num1 + num2}");
        }
        else if (operation == "substraction")
        {
            Debug.Log($"{num1} - {num2} = {num1 - num2}");
        }
        else if (operation == "product")
        {
            Debug.Log($"{num1} x {num2} = {num1 * num2}");
        }
        else if (operation == "division")
        {
            Debug.Log($"{num1} : {num2} = {num1 / num2}");
        }
        else
        {
            Debug.Log($"{operation} is not an operation avaliable or existing");
        }
    }
}
