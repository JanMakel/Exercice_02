using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    //Variables
    public float entero;


    private void Start()
    {
        //If the variable is grater than zero the number has to be positive
        if(entero > 0)
        {
            Debug.Log($"The number {entero} it's positive");
        }
        //If the variable is equal to zero...
       else if(entero == 0)
        {
            Debug.Log($"The number {entero} it's zero");
        }
        //if the number is not zero or positive must be negative
        else{
            Debug.Log($"The number {entero} it's negative");
        }
        
        
    }
}
