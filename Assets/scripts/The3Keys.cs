using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The3Keys : MonoBehaviour
{
    public bool KeyRed;
    public bool KeyBlue;
    public bool KeyGreen;


    void Start()
    {
     if (Zamok()== true)
        {
            Debug.Log("Замок открыт");
        }
     else
        {
            Debug.Log("Замок закрыт");
        }
    }

    private bool Zamok()
    {
        Debug.Log("Выбранные ключи:");
        if (KeyRed == true)
        {
            Debug.Log("Красный ключ вставлен");
            if (KeyBlue == true)
            {
                Debug.Log("Синий ключ вставлен");
                if (KeyGreen == true)
                {
                    Debug.Log("Зеленый ключ вставлен");
                    return true;
                }
            }
        }
        if (KeyRed == false)
        {
            Debug.Log("Красного ключа нет");

            if (KeyBlue == false)
            {
                Debug.Log("Синего ключа нет");

                if (KeyGreen == false)
                {
                    Debug.Log("зеленого ключа нет");
                    return false;
                }
            }
        }
        return false;
    }
}

