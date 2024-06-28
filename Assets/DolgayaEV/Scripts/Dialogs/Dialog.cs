using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DolgayaEV.Dialogs
{

    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnEnded;

        private Fraza _fraza; // ��� ������ �� ��������� �������� �����. (������� ������ � �����������)
        private DialogActivator _dialogActivator; // ������ �� ������� ��������� 
        private DialogViey _dialogviey;
        private bool _isCurrent;

        private void Awake() // ����� ����������� /������������ ����������� 
        {
            _fraza = GetComponent<Fraza>(); // � ������� ������ GetComponent ������� ������ ����� ������� ��������� Fraza
            _dialogviey = FindObjectOfType<DialogViey>(); // ���� ��������� DialogViey ������� ���-�� �� ����� �� �����������. 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ���� ��������� ��������� ������� 
            //���������� ����� ������ �������� _dialogActivator - ������, ��� ���� �� �� �������� null, _dialogActivator = null, 
        }

        public void StartDialog() // ������ �������
        {
            _isCurrent = true;
            Skazaty();
        }

        public void NextFraza() //��������� ����� 
        {
            Skazaty();
            if (_isCurrent == false)
                return;             
        }

        private void Skazaty() // ��������� ��� ������ ������ ����� ��������, ���������� ����� 
        {
            if (_fraza != null)
            {
                _dialogviey.SetFraza(_fraza);
                _fraza = _fraza.NextFraza;
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(_isInputBack);
                OnEnded.Invoke();
            }
        }

        private void Update() // ������������ ������� ������ ������ 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextFraza();
            }
        }
    }

}