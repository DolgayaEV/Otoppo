using DolgayaEV;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace KrikunLS.Dialogs
{
    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnEnded;

        private Fraza _fraza;// ��� ������ �� ��������� ������� ����� (�� ������� ������, ��� ��������� ����������)
        private DialogView _dialogView;
        private DialogActivator _dialogActivator;
        private bool _isCurrent;
       
        private void Awake() //����������� ������ �� ���������� - ����������� �������� �������
        {
           _fraza = GetComponent<Fraza>(); // � ������� ������ GetComponent ������ ������� ����� �������� ��������� �����
            _dialogView = FindObjectOfType<DialogView>(); // � ������� ������ FindObjectOfType ������� ������ ����������� ���� (��������� ����� ������), ������� ����� �� �����, � �� ������ ����������� ���-�� �� �����
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ���������� ����� ������, ��������� ������ DialogActivator (����� ����), ��� ���� �� DialogActivator = null
        }

        public void StartDialog()
        {
            _isCurrent = true;  
            Say();
        }
        public void NextFraza() 
        {
            if (_isCurrent == false)
                return;
            Say();
        }

        private void Say()
        {
            if (_fraza != null) 
            {
              _dialogView.SetFraza(_fraza);
                _fraza = _fraza.NextFraza;
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(_isInputBack);  
                OnEnded.Invoke();
            }

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextFraza();
            }
        }
    }
}