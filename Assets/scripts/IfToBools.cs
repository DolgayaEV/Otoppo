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
            Debug.Log("����������� �������");
        }

        if (Direcshon == false) // == ��������, = ���������
        {
            Direcshon = true;
            Debug.Log("����������� ����������"); // ��������� � �������
        }
        Debug.Log("����� ������ � ����� �� ���������");
        // ���� �� ����� ��������� � ���������� 
        //�� ������ �������� � ���� ������� if {} 

    }

    private void Update()
    {
        
    }
}
