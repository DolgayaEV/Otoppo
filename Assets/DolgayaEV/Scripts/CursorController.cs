using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{
    public class CursorController : MonoBehaviour
    {
        // ���������� ���� ���� � ����������, ����� ������� ��������� ��������� �������
        public bool isCursorVisible = true;

        void Start()
        {
            // ������������� ��������� ������� � ����������� �� �����
            SetCursorVisibility(isCursorVisible);
        }

        void Update()
        {
            // ������ ������������ ��������� ������� �� ������� ������� "C"
            if (Input.GetKeyDown(KeyCode.C))
            {
                isCursorVisible = !isCursorVisible;
                SetCursorVisibility(isCursorVisible);
            }
        }

        public void SetCursorVisibility(bool visible)
        {
            Cursor.visible = visible;
            Cursor.lockState = visible ? CursorLockMode.None : CursorLockMode.Locked; // ������������� ������, ���� �� �� �����
        }
    }



}

