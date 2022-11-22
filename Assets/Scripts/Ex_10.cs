using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_10 : MonoBehaviour
{
    //variable
    public int year;

    private void Start()
    {
        //When the year is divisible by 4 and the division of the year by 100 it's not exact then the year it's a leap year - but if the division by 100 it's exact
        //and if you divide by 400 it's exact too it is also a leap year
        if(year % 4 == 0 && year % 100 > 0 || year % 400 == 0)
        {
            Debug.Log($"The year {year} it's a leap year");
        }
        else
        {
            Debug.Log($"The year {year} it is not a leap year");
        }
    }
}
