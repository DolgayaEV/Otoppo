using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TSentler.Dialogs
{
    public class Dialog : MonoBehaviour
    {
        public bool AutoStart;
        public bool IsInputBack = true;
        public UnityEvent OnStarted;
        public UnityEvent OnEnded;

        private Phrase _currentPhrase; //������ �� ��������� ������� �����
        private Phrase _firstPhrase;
        private DialogActivator _dialogActivator;
        private DialogView _dialogView;
        private DialogButtons _dialogButtons;
        private BackgroundSwitcher _backgroundSwitcher;
        private Camera _currentCamera;
        private bool _isCurrent;

        private void Awake()
        {
            _firstPhrase = GetComponent<Phrase>(); //� ������� ������ GetComponent ������� ������ ����� ������� ��������� 
            _dialogView = FindObjectOfType<DialogView>(); //���� ��������� DialogView ������� ����� �� �����(�� ����� �� ���� �������).
            _dialogButtons = FindObjectOfType<DialogButtons>(); //���� ��������� DialogButtons ������� ����� �� �����(�� ����� �� ���� �������).
            _dialogActivator = FindObjectOfType<DialogActivator>(); //���������� ����� ������ �������� _dialogActivator ������ ��� ���� �� �� ��� �������� null _dialogActivator = null
            _backgroundSwitcher = FindObjectOfType<BackgroundSwitcher>();
        }

        private void Start()
        {
            if (AutoStart)
            {
                StartDialog();
            }
        }

        public Phrase GetCurrentPhrase() => _currentPhrase;
        public PhraseFork GetCurrentPhraseFork() => _currentPhrase as PhraseFork;

        public void StartDialog()
        {
            _isCurrent = true;
            _dialogButtons.SetDialog(this);
            _dialogActivator.Activate();
            _currentPhrase = _firstPhrase;
            Say();
            OnStarted.Invoke();
        }

        public void NextPhrase()
        {
            if (_isCurrent == false)
                return;

            _currentPhrase = _currentPhrase.GetNextPhrase();
            Say();
        }

        private void Say()
        {
            if (_currentPhrase != null)
            {
                _dialogView.SetPhrase(_currentPhrase);
                CameraActivate();
                _backgroundSwitcher.ActivateByIndex(_currentPhrase.BackgroundIndex);
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(IsInputBack);
                CameraDeactivate();
                _backgroundSwitcher.DeactivateAll();
                OnEnded.Invoke();
            }
        }

        private void CameraActivate()
        {
            if (_currentPhrase.Camera == null)
                return;

            CameraDeactivate();
            _currentCamera = _currentPhrase.Camera;
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