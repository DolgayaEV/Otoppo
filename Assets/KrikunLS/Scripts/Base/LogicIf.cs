using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrikunLS
{
    public class LogicIf : MonoBehaviour
    {
        public bool KeyRed;
        public bool KeyGreen;

       private void Start()
        {
            //����� ������������ && � || ������ - ����� � & ����� ��������� ��� || ��� � * ����� +
            And();
            Or();
        }

        private void Or()
        {
            if (KeyRed == true)
            {
                Debug.Log("Open!");
            }
            else if (KeyGreen == true)
            {
                Debug.Log("Open!");
            }

            if (KeyGreen == true || KeyRed == true)// �������������� ���������� ���� �� ������ ������� - ���� ������ ���������, �� ����������� ���� �� ����� ��������� || - ���� ���������� "���" (1+1)
            {
                Debug.Log("Open!");
            }
        }

        private void And()
        {
            if (KeyRed == true)
            {
                if (KeyGreen == true)
                {
                    Debug.Log("Open!");
                }
            }

            if (KeyRed == true && KeyGreen == true) //&& - ���������� "�", ����������� ���������� ������������ ��������� ������� (1*1)
            {
                Debug.Log("Open!");
            }
        }

        private void Update()
        {
        
        }
    }

}