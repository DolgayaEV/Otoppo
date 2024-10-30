using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{
    public class CursorController : MonoBehaviour
    {
        // Установите этот флаг в инспекторе, чтобы указать начальное состояние курсора
        public bool isCursorVisible = true;

        void Start()
        {
            // Устанавливаем видимость курсора в зависимости от флага
            SetCursorVisibility(isCursorVisible);
        }

        void Update()
        {
            // Пример переключения состояния курсора по нажатию клавиши "C"
            if (Input.GetKeyDown(KeyCode.C))
            {
                isCursorVisible = !isCursorVisible;
                SetCursorVisibility(isCursorVisible);
            }
        }

        public void SetCursorVisibility(bool visible)
        {
            Cursor.visible = visible;
            Cursor.lockState = visible ? CursorLockMode.None : CursorLockMode.Locked; // Заблокировать курсор, если он не видим
        }
    }



}

