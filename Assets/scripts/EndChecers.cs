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
            Debug.Log("�������");

        }
        
        if (Shoes == true)
        {
            Debug.Log("�������� �� ������");
        }
       
    }

    private void Update()
    {
        
    }
}
