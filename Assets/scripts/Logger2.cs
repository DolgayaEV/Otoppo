using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Android;

public class Logger2 : MonoBehaviour
{
    public string Name;
    public string Familiya;
    public string Otchestvo;
    public int Old;

    void Start()
    {
        MessageLog(Familiya, Name, Otchestvo); // ����������� ����, �� ��� ��������� � �������, ����� ��������� �����
        bool b = MessageLog(Familiya, Name, Otchestvo); // ������ ���������� ������� b, ��� ����� ���������� ��� � �������������. 
        Debug.Log(b); // ������ � ������� ��������� (� ����� ������ ���������� b)
        int c = Old;
        Debug.Log(c);
    }

    private bool MessageLog(string f, string n, string o) // ����� ������ ������� (��� ������ � ������), ����������� � ������ � ��� �� ������ �������� � ��� ����������.
    {
        Debug.Log(GetFio(f, n, o)); // ������ �������� � ������� 
        return true; // ������� �� ������� - ��� 
    }

    private string GetFio(string f, string n, string o)
    {
        return "���:" + f + " " + n + " " + o;
    }

}
