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
            Debug.Log("����� ������");
        }
     else
        {
            Debug.Log("����� ������");
        }
    }

    private bool Zamok()
    {
        Debug.Log("��������� �����:");
        if (KeyRed == true)
        {
            Debug.Log("������� ���� ��������");
            if (KeyBlue == true)
            {
                Debug.Log("����� ���� ��������");
                if (KeyGreen == true)
                {
                    Debug.Log("������� ���� ��������");
                    return true;
                }
            }
        }
        if (KeyRed == false)
        {
            Debug.Log("�������� ����� ���");

            if (KeyBlue == false)
            {
                Debug.Log("������ ����� ���");

                if (KeyGreen == false)
                {
                    Debug.Log("�������� ����� ���");
                    return false;
                }
            }
        }
        return false;
    }
}

