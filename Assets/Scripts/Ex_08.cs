using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour
{
    //variables
    public int points;

    private void Start()
    {
        //Depend on the points you have you'll recive diferents answers
        if (points > 100)
        {
            Debug.Log($"You have more than 100 points");
        }
        else if (points > 75 && points <= 100)
        {
            Debug.Log($"You have more than 75 points but less or equal to 100");
        }
        else if(points <= 75 && points > 50)
        {
            Debug.Log($"You have more than 50 points but less or equal to 75");
        }
        else if(points <= 50 && points > 25)
        {
            Debug.Log($"You have more than 25 points but less or equal to 50");
        }
        else
        {
            Debug.Log($"You have less or equal than 25 points");
        }
    }
}
