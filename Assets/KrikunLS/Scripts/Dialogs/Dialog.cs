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

        private Fraza _currentFraza;// это ссылка на компонент текущей фразы (на область памяти, где находится информация)
        private Fraza _firstFraza;
        private DialogView _dialogView;
        private DialogButtons _dialogButtons;
        private BackgroubdSwitcher _backgroundSwitcher;
        private DialogActivator _dialogActivator;
        private Camera _currentCamera;
        private bool _isCurrent;
       
        private void Awake() //прокидывает ссылки на компоненты - техническая сторонра вопроса
        {
            _firstFraza = GetComponent<Fraza>(); // с помощью метода GetComponent первый находим рядом длежащий компонент фраза
            _dialogView = FindObjectOfType<DialogView>(); // с помощью метода FindObjectOfType находим объект конкретного типа (указываем какой именно), который лежит не рядом, а на другом геймобъекте где-то на сцене
            _dialogButtons = FindObjectOfType<DialogButtons>(); 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // изначально любая ссылка, нгапример пустая DialogActivator (равна нулю), как если бы DialogActivator = null
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