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
        // float summ = Calculator.Plus(All, Level); - неправильное использование - со статикой сложнее отследить где используем, потому что статик позволяет использовать без привязки - везде!

        float x = 0f;
        //создаем экземпляр класса Calculator.
        //переменная calc - коробка, в которой ничего нет.(null - что-то, void - где-то)
        //мы создаем калькулятор и помещаем его коробку - в переменную calc
        
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
