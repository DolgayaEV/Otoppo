using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DolgayaEV.Dialogs
{

    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnStarted;
        public UnityEvent OnEnded;
            
        private Fraza _fraza; // ��� ������ �� ��������� �������� �����. (������� ������ � �����������)
        private DialogActivator _dialogActivator; // ������ �� ������� ��������� 
        private DialogViey _dialogviey;
        private Camera _currentCamera;
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
            _isCurrent = true; // ������ ������ �������������
            _dialogActivator.Activate(); // ����������� � ������ ����������, �� ����� ����������� ������ 
            Skazaty(); // �������������� �����, ���������� � ���� ���������
            OnStarted.Invoke();
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
                _fraza = _fraza.GetNextFraza();
                _dialogviey.SetFraza(_fraza);
                CameraActivate();
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(_isInputBack);
                CameraDiactivate();
                OnEnded.Invoke();
            }
        }

        private void CameraActivate()
        {
            if (_fraza.Camera == null)
                return;
            
            CameraDiactivate();
            _currentCamera = _fraza.Camera;
            _currentCamera.gameObject.SetActive(true);
        }

        private void CameraDiactivate()
        {
            if (_currentCamera != null)
            {
                _currentCamera.gameObject.SetActive(false);
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