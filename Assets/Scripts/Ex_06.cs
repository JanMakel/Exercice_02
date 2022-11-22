using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_06 : MonoBehaviour
{
    //Variable
    public float distanceTraveled;
    public float distanceToTravel;

    private void Start()
    {
        //Operation of the distance to travel in diference of the distance traveld
        if(distanceToTravel - distanceTraveled <= 0)
        {
            Debug.Log($"Congratulations! You have completed the total distance");
        }
        else
        {
            Debug.Log($"Oh… You still have {distanceToTravel - distanceTraveled} meters left to complete the total distance");
        }
    }
}
