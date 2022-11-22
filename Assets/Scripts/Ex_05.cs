using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    //Variable
    public int age;

    private void Start()
    {
        //If you have less than 18 years you are not of legal age
        if(age < 18)
        {
            Debug.Log($"Hello, you are {age} years old, so you are  not of legal age");
        }
        else
        {
            Debug.Log($"Hello, you are {age} years old, so you are of legal age");
        }
    }
}
