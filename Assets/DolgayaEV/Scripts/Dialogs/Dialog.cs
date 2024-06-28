using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DolgayaEV.Dialogs
{

    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnEnded;

        private Fraza _fraza; // это ссылка на компонент текущшей фразы. (область памяти с информацией)
        private DialogActivator _dialogActivator; // сыылка на идиалог активатор 
        private DialogViey _dialogviey;
        private bool _isCurrent;

        private void Awake() // поиск компонентов /прокидывание компонентов 
        {
            _fraza = GetComponent<Fraza>(); // с помощью метода GetComponent находим первый рядом лежащий компонент Fraza
            _dialogviey = FindObjectOfType<DialogViey>(); // ищем компонент DialogViey который где-то на сцене на геймобьекте. 
            _dialogActivator = FindObjectOfType<DialogActivator>(); // ищет компонент активатор диалога 
            //изначально любая ссылка например _dialogActivator - пустая, как если бы ей присвоен null, _dialogActivator = null, 
        }

        public void StartDialog() // начало диалога
        {
            _isCurrent = true;
            Skazaty();
        }

        public void NextFraza() //следующая фраза 
        {
            Skazaty();
            if (_isCurrent == false)
                return;             
        }

        private void Skazaty() // приватный для метода Диалог умеет говорить, показывает фразы 
        {
            if (_fraza != null)
            {
                _dialogviey.SetFraza(_fraza);
                _fraza = _fraza.NextFraza;
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(_isInputBack);
                OnEnded.Invoke();
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