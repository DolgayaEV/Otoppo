using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicIf : MonoBehaviour
{
    public bool KeyRed;
    public bool KeyGreen;
    
    private void Start()
    {
        // Можно использовать && и || вместе. 
        //Тогда у && будет приоритет над ||, как у знака "*" над "+"
        And();

        Or();
    }

    private void Or()
    {
        if (KeyRed == true)
        {
            Debug.Log("Открыто");
        }
        else if (KeyGreen == true)
        {
            Debug.Log("Открыто");
        }

        if (KeyGreen == true || KeyRed == true) // || - логическая "ИЛИ". 1 + 1
        {
            Debug.Log("Открыто");
        }
    }

    private void And()
    {
        if (KeyRed == true) // Проверка нескольких вариантов
        {
            if (KeyGreen == true)
            {
                Debug.Log("Открыто");
            }

        }

        if (KeyRed == true && KeyGreen == true) // Двойной эмперсант & - логическое "И". 1 * 1 
        {
            Debug.Log("Открыто");
        }
    }

    private void Update()
    {
        
    }
}
