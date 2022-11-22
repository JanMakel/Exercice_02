using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    //Variables
    public float Base;
    public float heigh;

    private void Start()
    {
        //If the base or the heigh are negative numbers the area of a triangle can't be calculated
        if(Base < 0 || heigh < 0)
        {
            Debug.Log($"The Base or the heigh are negative and the area can not be calculated");
        }
        else
        {
            Debug.Log($"The area of the triangle it's {(Base * heigh) / 2}");
        }
    }
}
