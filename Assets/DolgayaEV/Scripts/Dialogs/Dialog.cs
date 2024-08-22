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
            
        private Fraza _currentFraza; // это ссылка на компонент текущшей фразы. (область памяти с информацией)
        private Fraza _firstFraza;
        private DialogActivator _dialogActivator; // сыылка на идиалог активатор 
        private DialogViey _dialogviey;
        private Camera _currentCamera;
        private bool _isCurrent;

        private void Awake() // поиск компонентов /прокидывание компонентов 
        {
            _firstFraza = GetComponent<Fraza>(); // с помощью метода GetComponent находим первый рядом лежащий компонент Fraza
            _dialogviey = FindObjectOfType<DialogViey>(); // ищем компонент DialogViey который где-то на сцене на геймобьекте. 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ищет компонент активатор диалога 
            //изначально любая ссылка например _dialogActivator - пустая, как если бы ей присвоен null, _dialogActivator = null, 
        }

        public void StartDialog() // начало диалога
        {
            _isCurrent = true; // данный диалог функционирует
            _dialogActivator.Activate(); // отсылаеться к диалог активатору, на конве показывавет панель 
            _currentFraza = _firstFraza;
            Skazaty(); // перелистывание фразы, отображает в юзер интерфейс
            OnStarted.Invoke();
        }

        public void NextFraza() //следующая фраза 
        {
            if (_isCurrent == false)
                return;             
            _currentFraza = _currentFraza.GetNextFraza();
            Skazaty();
        }

        private void Skazaty() // приватный для метода Диалог умеет говорить, показывает фразы 
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

        private void Update() // отслеживание нажатия кнопки пробел 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextFraza();
            }
        }
    }

}