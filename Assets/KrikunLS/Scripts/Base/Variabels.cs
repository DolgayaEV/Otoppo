using System;
using UnityEngine;

public class Variabels : MonoBehaviour
{
    public int Number1 = 9; //public/private - параметр доступности, int - целочисленный тип; Number1 - имч поля; = 5 необязательное значение по умолчанию; 
    public float Number2 = 4.3f; // 
    public string Name2 = "lucka"; // хранение информации для вывода игроку на экране
    public bool IsCheck1 = true; // точка выполнения условий; true - истина или выполнено;   
    public bool IsCheck2 = false; //точка выполнения условий; false - ложное
    public double NumberDouble = 9.99567;
    public Decimal NumberDecimal = 9.99567M;

    private string _name1;
}