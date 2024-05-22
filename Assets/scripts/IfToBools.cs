using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfToBools : MonoBehaviour
{

    public bool Direcshon; 
  
    private void Start()
    {
        if (Direcshon == true)
        {
            Debug.Log("Ќаправление прежнее");
        }

        if (Direcshon == false) // == сравнить, = присвоить
        {
            Direcshon = true;
            Debug.Log("Ќаправление изменилось"); // описываем в консоль
        }
        Debug.Log("“екст выйдет в любом из вариантов");
        // если мы хотим прив€зать к результату 
        //то должны включать в тело услови€ if {} 

    }

    private void Update()
    {
        
    }
}
