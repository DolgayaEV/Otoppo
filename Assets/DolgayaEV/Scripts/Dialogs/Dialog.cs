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
            
        private Fraza _currentFraza; // ��� ������ �� ��������� �������� �����. (������� ������ � �����������)
        private Fraza _firstFraza;
        private DialogActivator _dialogActivator; // ������ �� ������� ��������� 
        private DialogViey _dialogviey;
        private Camera _currentCamera;
        private bool _isCurrent;

        private void Awake() // ����� ����������� /������������ ����������� 
        {
            _firstFraza = GetComponent<Fraza>(); // � ������� ������ GetComponent ������� ������ ����� ������� ��������� Fraza
            _dialogviey = FindObjectOfType<DialogViey>(); // ���� ��������� DialogViey ������� ���-�� �� ����� �� �����������. 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ���� ��������� ��������� ������� 
            //���������� ����� ������ �������� _dialogActivator - ������, ��� ���� �� �� �������� null, _dialogActivator = null, 
        }

        public void StartDialog() // ������ �������
        {
            _isCurrent = true; // ������ ������ �������������
            _dialogActivator.Activate(); // ����������� � ������ ����������, �� ����� ����������� ������ 
            _currentFraza = _firstFraza;
            Skazaty(); // �������������� �����, ���������� � ���� ���������
            OnStarted.Invoke();
        }

        public void NextFraza() //��������� ����� 
        {
            if (_isCurrent == false)
                return;             
            _currentFraza = _currentFraza.GetNextFraza();
            Skazaty();
        }

        private void Skazaty() // ��������� ��� ������ ������ ����� ��������, ���������� ����� 
        {

            if (_currentFraza != null)
            {
                _dialogviey.SetFraza(_currentFraza);
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
            if (_currentFraza.Camera == null)
                return;
            
            CameraDiactivate();
            _currentCamera = _currentFraza.Camera;
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