using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{

public class ProbelActive : MonoBehaviour
{

    public GameObject targetObject; // ������ �� ������, � ������� ����� ��������

        void Update()
        {
            // ���������, ���� �� ������ ������� �������
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // �������� ������� ��� ������� �������
                ActivateFunction();
            }
        }

        void ActivateFunction()
        {
            // ����� ����� ����������, ��� ������ ����� �����������
            // ��������, ���������� ������ ��� ��������� ������ ������
            if (targetObject != null)
            {
                targetObject.SetActive(!targetObject.activeSelf); // ����������� ��������� �������
                Debug.Log("������� ������������! ������� ������ �������: " + targetObject.activeSelf);
            }
            else
            {
                Debug.LogWarning("������� ������ �� ��������!");
            }
        }
    }




}
