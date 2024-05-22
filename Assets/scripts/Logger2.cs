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
        MessageLog(Familiya, Name, Otchestvo); // прописываем сюда, то что появиться в консоли, внизу описываем метод
        bool b = MessageLog(Familiya, Name, Otchestvo); // задаем постоянную булевую b, она будет показывать тру в независимости. 
        Debug.Log(b); // запись в консоль состояний (в нашем случае постоянной b)
        int c = Old;
        Debug.Log(c);
    }

    private bool MessageLog(string f, string n, string o) // сразу ставим булевую (она задана в старте), расписываем в методе с чем он должен работать и что возвращать.
    {
        Debug.Log(GetFio(f, n, o)); // запись перехода в консоль 
        return true; // возврат по булевой - тру 
    }

    private string GetFio(string f, string n, string o)
    {
        return "ФИО:" + f + " " + n + " " + o;
    }

}
