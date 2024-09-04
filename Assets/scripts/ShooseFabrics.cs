using UnityEngine;

public class ShooseFabrics : MonoBehaviour
{
    public bool Botinki; // переменные, которые мы должны вывести в юнити
    public bool Kedy;
    public bool Valenki;


    private void Start()
    {
       if (ShoeCheck()== true) // обьединили в один метод три переменн
        {
            Debug.Log("Добрался до работы");
        }
        else // иначе для всех других вариаентов, нужно в конце чтобы не замещал другие 
        {
            Debug.Log("Попал в больницу");
        }
    }



    private bool ShoeCheck()
    {
        Debug.Log("Выбранные:");
        if (Botinki == true)
        {
            Debug.Log("Ботинки");
            return true; // правильный выбор и дальше не пойдет
        }
        else if (Kedy == true)
        {
            Debug.Log("Кеды");
            Valenki = false;
        }
        else if (Valenki == true)
        {
            Debug.Log("Валенки");
            Kedy = false;
        }
        return false; // нет правильного ответа поэтому пойдет заново
    }

    private void Update()
    {
        
    }
}
