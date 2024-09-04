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
        public bool AutoStart;
        public bool IsInputBack = true;
        public bool IsActiveCameraAtEnd;
        public UnityEvent OnStarted;
        public UnityEvent OnEnded;

        private Fraza _currentFraza;// ��� ������ �� ��������� ������� ����� (�� ������� ������, ��� ��������� ����������)
        private Fraza _firstFraza;
        private DialogView _dialogView;
        private DialogButtons _dialogButtons;
        private BackgroubdSwitcher _backgroundSwitcher;
        private DialogActivator _dialogActivator;
        private Camera _currentCamera;
        private bool _isCurrent;
       
        private void Awake() //����������� ������ �� ���������� - ����������� �������� �������
        {
            _firstFraza = GetComponent<Fraza>(); // � ������� ������ GetComponent ������ ������� ����� �������� ��������� �����
            _dialogView = FindObjectOfType<DialogView>(); // � ������� ������ FindObjectOfType ������� ������ ����������� ���� (��������� ����� ������), ������� ����� �� �����, � �� ������ ����������� ���-�� �� �����
            _dialogButtons = FindObjectOfType<DialogButtons>(); 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ���������� ����� ������, ��������� ������ DialogActivator (����� ����), ��� ���� �� DialogActivator = null
            _backgroundSwitcher = FindObjectOfType<BackgroubdSwitcher>();
        }



        private void Start()
        {
            if (AutoStart)
            {
                StartDialog();
            }
        }
        public Fraza GetCurrentFraza () => _currentFraza;
        public FrazaRazvilka GetCurrentFrazaRazvilka () => _currentFraza as FrazaRazvilka;

        public void StartDialog()
        {
            _isCurrent = true;
            _dialogButtons.SetDialog(this);
            _dialogActivator.Activate();
            _currentFraza = _firstFraza;
            Say();
            OnStarted.Invoke(); 
        }
        public void NextFraza() 
        {
            if (_isCurrent == false)
                return;
            _currentFraza = _currentFraza.GetNextFraza();
            Say();
        }
        private void Say()
        {
            if (_currentFraza != null)
            {
                _dialogView.SetFraza(_currentFraza);
                CameraActivate();
                _backgroundSwitcher.ActivateByIndex(_currentFraza.BackgroundIndex);
                _currentFraza.OnStarted.Invoke();
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(IsInputBack);
                if (IsActiveCameraAtEnd == false) 
                {
                    CameraDeactivate(); 
                }
                _backgroundSwitcher.DeactivateAll();
                OnEnded.Invoke();
            }
        }

        private void CameraActivate()
        {
            if (_currentFraza.Camera == null)
                return;

            CameraDeactivate();
            _currentCamera = _currentFraza.Camera;
            _currentCamera.gameObject.SetActive(true);
        }

        private void CameraDeactivate()
        {
            if (_currentCamera != null)
            {
                _currentCamera.gameObject.SetActive(false);
            }
        }

        
    }
}