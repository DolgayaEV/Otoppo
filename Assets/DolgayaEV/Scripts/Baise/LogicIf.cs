using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicIf : MonoBehaviour
{
    public bool KeyRed;
    public bool KeyGreen;
    
    private void Start()
    {
        // ����� ������������ && � || ������. 
        //����� � && ����� ��������� ��� ||, ��� � ����� "*" ��� "+"
        And();

        Or();
    }

    private void Or()
    {
        if (KeyRed == true)
        {
            Debug.Log("�������");
        }
        else if (KeyGreen == true)
        {
            Debug.Log("�������");
        }

        if (KeyGreen == true || KeyRed == true) // || - ���������� "���". 1 + 1
        {
            Debug.Log("�������");
        }
    }

    private void And()
    {
        if (KeyRed == true) // �������� ���������� ���������
        {
            if (KeyGreen == true)
            {
                Debug.Log("�������");
            }

        }

        if (KeyRed == true && KeyGreen == true) // ������� ��������� & - ���������� "�". 1 * 1 
        {
            Debug.Log("�������");
        }
    }

    private void Update()
    {
        
    }
}
