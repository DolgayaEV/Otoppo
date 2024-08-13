using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TSentler.Dialogs
{
    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnStarted;
        public UnityEvent OnEnded;

        private Phrase _phrase; //������ �� ��������� ������� �����
        private DialogActivator _dialogActivator;
        private DialogView _dialogView;
        private Camera _currentCamera;
        private bool _isCurrent;

        private void Awake()
        {
            _phrase = GetComponent<Phrase>(); //� ������� ������ GetComponent ������� ������ ����� ������� ��������� 
            _dialogView = FindObjectOfType<DialogView>(); //���� ��������� DialogView ������� ����� �� �����(�� ����� �� ���� �������).
            _dialogActivator = FindObjectOfType<DialogActivator>(); //���������� ����� ������ �������� _dialogActivator ������ ��� ���� �� �� ��� �������� null _dialogActivator = null
        }

        public void StartDialog()
        {
            _isCurrent = true;
            _dialogActivator.Activate();
            Say();
            OnStarted.Invoke();
        }

        public void NextPhrase()
        {
            if (_isCurrent == false)
                return;

            Say();
        }

        private void Say()
        {
            if (_phrase != null)
            {
                _dialogView.SetPhrase(_phrase);
                CameraActivate();
                _phrase = _phrase.NextPhrase;
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
            if (_phrase.Camera == null)
                return;

            CameraDeactivate();
            _currentCamera = _phrase.Camera;
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
                NextPhrase();
            }
        }
    }
}