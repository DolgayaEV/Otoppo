using DolgayaEV;
using System.Collections;
using System.Collections.Generic;
using TSentler;
using UnityEngine;
using UnityEngine.Events;


namespace KrikunLS.Dialogs
{
    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnStarted;
        public UnityEvent OnEnded;

        private Fraza _fraza;// ��� ������ �� ��������� ������� ����� (�� ������� ������, ��� ��������� ����������)
        private DialogView _dialogView;
        private DialogActivator _dialogActivator;
        private Camera _currentCamera;
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
            _dialogActivator.Activate();
            Say();
            OnStarted.Invoke(); 
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
                _fraza = _fraza.GetNextFraza();
                _dialogView.SetFraza(_fraza);
                CameraActivate();
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(_isInputBack);
                CameraDeactivate(); 
                OnEnded.Invoke();
            }
        }

        private void CameraActivate()
        {
            if (_fraza.Camera == null)
                return;

            CameraDeactivate();
            _currentCamera = _fraza.Camera;
            _currentCamera.gameObject.SetActive(true);
        }

        private void CameraDeactivate()
        {
            if (_currentCamera != null)
            {
                _currentCamera.gameObject.SetActive(false);
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