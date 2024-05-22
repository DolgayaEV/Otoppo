using UnityEngine;

public class Variables : MonoBehaviour
{
    public int Number1 = 10; //public/private - параметр доступности;int -целочисленный тип; Number1 - имя поля; =5 не обязательное значание по умолчанию;
    public float Number = 7.1f;//public/privat - параметр доступности; float - числа с запятой, сотые; = 7.1f не обязательное значение по умолчанию, f для отображения;
    public string Name1 = "hhhvvcxxx"; //public - пароаметр доступности; string - оператор для написания текста; = "hahah" - не обязательное значение по умолчанию;
    public bool IsCheck1 = true;//public - параметр доступности; bool - прараметр правда или ложь (галочка); true - правда; 
    public bool IsCheck2 = false;//public - параметр доступности; bool - прараметр правда или ложь (галочка); false - ложь;

    private string _name2;
}