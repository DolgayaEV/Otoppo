using UnityEngine;
using UnityEngine.AI;

public class FioLogger : MonoBehaviour
{
    //��� ���������  ���������� ���������� 
    public string Name;
    public string Familiya;
    public string Otchestvo;
    public bool Sex;
    private int _number;



    //��� �������� ��������� ����������
    private void Start()
    {
        Simple();
        _number = _number + 1;
        Simple();

        string familiya = "��";
        string otchestvo = "�������������";
        FioLog(familiya, Name, otchestvo, 33, Sex);
        FioLog(familiya, Name, otchestvo, 33f);
        FioLog(Name, "������������", "������");
        FioLog(Name, "������������");
        FioLog("Cth");
        
        float x;
        x = 2f;
        float f = Function(x);
        FLog(f);

    }

    private float Function(float x)
    {
        Debug.Log("x = " + x);
        float result = x * x + x + 2;
        return result;
    }

    private void FLog(float f)
    {
        Debug.Log("f = " + f);
    }

    private void Simple()
    {
        Debug.Log(Name);
        Debug.Log(_number);
    }
    
    private void FioLog(string f, string n, string o)
    {
        Debug.Log(GetFio(f, n, o));
    }

    private string GetFio(string f, string n, string o)
    {
        return "���: " + f + " " + n + " " + o + "\n";
    }

    private void FioLog(string f, string n, string o, int age, bool sex )
    {
        string old = GetAge(age);
        Debug.Log(GetFio(f, n, o) + " " + old + " " + sex);
    }

    private string GetAge(int age) 
    {
        return "�������: " + age + "\n"; 
    }

    private void FioLog(string f, string n, string o, float h)
    {
        string fio = GetFio(f, n, o);
        string height = GetHeight(h);
        Debug.Log(fio + " " + height);
    }

    private string GetHeight(float h)
    {
        return "����: " + h + "\n";
    }

    private void FioLog(string name)
    {
        Debug.Log(name);
    }

    private void FioLog(string f, string n)
    {
        Debug.Log("���: " + f + " " + n);
    }

}

