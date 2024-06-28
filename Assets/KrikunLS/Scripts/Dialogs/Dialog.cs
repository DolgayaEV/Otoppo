using DolgayaEV;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace KrikunLS.Dialogs
{
    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnEnded;

        private Fraza _fraza;// это ссылка на компонент текущей фразы (на область памяти, где находится информация)
        private DialogView _dialogView;
        private DialogActivator _dialogActivator;
        private bool _isCurrent;
       
        private void Awake() //прокидывает ссылки на компоненты - техническая сторонра вопроса
        {
           _fraza = GetComponent<Fraza>(); // с помощью метода GetComponent первый находим рядом длежащий компонент фраза
            _dialogView = FindObjectOfType<DialogView>(); // с помощью метода FindObjectOfType находим объект конкретного типа (указываем какой именно), который лежит не рядом, а на другом геймобъекте где-то на сцене
            _dialogActivator = FindObjectOfType<DialogActivator>(); // изначально любая ссылка, нгапример пустая DialogActivator (равна нулю), как если бы DialogActivator = null
        }

        public void StartDialog()
        {
            _isCurrent = true;  
            Say();
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
              _dialogView.SetFraza(_fraza);
                _fraza = _fraza.NextFraza;
            }
            else
            {
                _isCurrent = false;
                _dialogActivator.Deactivate(_isInputBack);  
                OnEnded.Invoke();
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