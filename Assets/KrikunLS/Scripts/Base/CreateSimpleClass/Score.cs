using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float All;
    public float Level;

    void Start()
    {
        // float summ = Calculator.Plus(All, Level); - ������������ ������������� - �� �������� ������� ��������� ��� ����������, ������ ��� ������ ��������� ������������ ��� �������� - �����!

        float x = 0f;
        //������� ��������� ������ Calculator.
        //���������� calc - �������, � ������� ������ ���.(null - ���-��, void - ���-��)
        //�� ������� ����������� � �������� ��� ������� - � ���������� calc
        
        Calculator calc = new Calculator(); 
        float summ = calc.GetSumm(All, Level);
        float minus = calc.GetMinus(All, Level);

        Debug.Log(summ);
        Debug.Log(minus);
        
        Slagaemie slag = new Slagaemie();
        slag.All = All;
        slag.Level = Level;
        summ = calc.GetSumm(slag);
        Debug.Log(summ);
    }

}
