using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DolgayaEV
{
    public class Score : MonoBehaviour
    {
        public float All;
        public float Level;

        void Start()
        {
            // float x = 0f;
            Calculator cal = new Calculator(); // Создаём экземпляр класса Calculator
                                               // Переменная cal  это коробка в которой изначально ничего нет (null: что-то).
                                               // Мы создаём и помещаем его в коробку calc 
            float sum = cal.GetSum(All, Level);
            float diff = cal.GetDiff(All, Level);
            float sum3 = cal.GetSum(All, Level);
            float sum4 = cal.GetSum(All, Level);

            Slagaemoe sloga = new Slagaemoe();
            sloga.All = All;
            sloga.Level = Level;
            sum = cal.GetSum(sloga);

            Slagaemoe sloga2 = new Slagaemoe();
            sloga2.All = 3;
            sloga2.Level = 7;
            float sum2 = cal.GetSum(sloga2);



            Debug.Log(sum);
        }
    }
}