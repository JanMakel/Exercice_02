using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    //Variables
    public int divide5;

    private void Start()
    {
        //The module of the varible must be 0 to be divided by 5
        if(divide5 % 5 == 0)
        {
            Debug.Log($"The number {divide5} is divisble by 5");
        }
        else
        {
            Debug.Log($"The number {divide5} is not divisible by 5");
        }
    }

}
