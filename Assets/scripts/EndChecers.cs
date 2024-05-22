using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public bool Shoes; 

    private void Start()
    {
        if (Shoes == false)
        {
            Debug.Log("Замерзл");

        }
        
        if (Shoes == true)
        {
            Debug.Log("Добрался до работы");
        }
       
    }

    private void Update()
    {
        
    }
}
