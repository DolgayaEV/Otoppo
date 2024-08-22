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

        private Fraza _currentFraza;// это ссылка на компонент текущей фразы (на область памяти, где находится информация)
        private Fraza _firstFraza;
        private DialogView _dialogView;
        private DialogActivator _dialogActivator;
        private Camera _currentCamera;
        private bool _isCurrent;
       
        private void Awake() //прокидывает ссылки на компоненты - техническая сторонра вопроса
        {
            _firstFraza = GetComponent<Fraza>(); // с помощью метода GetComponent первый находим рядом длежащий компонент фраза
            _dialogView = FindObjectOfType<DialogView>(); // с помощью метода FindObjectOfType находим объект конкретного типа (указываем какой именно), который лежит не рядом, а на другом геймобъекте где-то на сцене
            _dialogActivator = FindObjectOfType<DialogActivator>(); // изначально любая ссылка, нгапример пустая DialogActivator (равна нулю), как если бы DialogActivator = null
        }

        public void StartDialog()
        {
            _isCurrent = true;
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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextFraza();
            }
        }
    }
}