using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_09 : MonoBehaviour
{
    //variables
    public bool wantsVegetarianOption;

    private void Start()
    {
        //I negate the bool to get the answer negative first and ture later
        if( ! wantsVegetarianOption)
        {
            Debug.Log($"Non-Vegetarian option coming soon");
        }
        else
        {
            Debug.Log($"Vegetarian option coming soon");
        }
    }
}
