using UnityEngine;

public class ShooseFabrics : MonoBehaviour
{
    public bool Botinki; // ����������, ������� �� ������ ������� � �����
    public bool Kedy;
    public bool Valenki;


    private void Start()
    {
       if (ShoeCheck()== true) // ���������� � ���� ����� ��� ��������
        {
            Debug.Log("�������� �� ������");
        }
        else // ����� ��� ���� ������ ����������, ����� � ����� ����� �� ������� ������ 
        {
            Debug.Log("����� � ��������");
        }
    }



    private bool ShoeCheck()
    {
        Debug.Log("���������:");
        if (Botinki == true)
        {
            Debug.Log("�������");
            return true; // ���������� ����� � ������ �� ������
        }
        else if (Kedy == true)
        {
            Debug.Log("����");
            Valenki = false;
        }
        else if (Valenki == true)
        {
            Debug.Log("�������");
            Kedy = false;
        }
        return false; // ��� ����������� ������ ������� ������ ������
    }

    private void Update()
    {
        
    }
}
