using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{

public class ProbelActive : MonoBehaviour
{

    public GameObject targetObject; // Ссылка на объект, с которым будем работать

        void Update()
        {
            // Проверяем, была ли нажата клавиша пробела
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Вызываем функцию при нажатии пробела
                ActivateFunction();
            }
        }

        void ActivateFunction()
        {
            // Здесь можно определить, что именно будет происходить
            // Например, активируем объект или выполняем другую логику
            if (targetObject != null)
            {
                targetObject.SetActive(!targetObject.activeSelf); // Переключаем состояние объекта
                Debug.Log("Функция активирована! Текущий статус объекта: " + targetObject.activeSelf);
            }
            else
            {
                Debug.LogWarning("Целевой объект не назначен!");
            }
        }
    }




}
