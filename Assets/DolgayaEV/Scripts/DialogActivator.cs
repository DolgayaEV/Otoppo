using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{
    public class DialogActivator : MonoBehaviour
    {
        public GameObject Dialog;

        private CharacterControls CharacterControls;

        private void Awake()
        {
            CharacterControls = FindObjectOfType<CharacterControls>();
            Dialog.SetActive(false); 
        }

        public void Activate()
        {
            CharacterControls.DialogActivate(); //�������� ������ ���������� ������� ��������� CharacterControls,
            //� ���� ��� ������������ ���������� ����. ���������� ���������� ���������
            Dialog.SetActive(true); //���������� ����������� ������� ��������.
        }

        public void Deactivate(bool isInputBack)
        {
            if (isInputBack)
            {
                CharacterControls.DialogDeactivade();
            }
            
            Dialog.SetActive(false);            
        }
    }
}