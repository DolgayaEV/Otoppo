using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrikunLS
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
            CharacterControls.DialogActivate(); // �������� ������ ���������� ��������� ��������� � ���, ��� ����������� ���������� ���� � ��� ���������� ��������� ���������� ����������
            Dialog.SetActive(true); // ��������� ����������� (������ ��������) - �������� �������   
        }
        public void Deactivate(bool isInputBack)
        {
            if (isInputBack)
            {
                CharacterControls.DialogDeactivate();
            }
            Dialog.SetActive(false);
        }
    }
}