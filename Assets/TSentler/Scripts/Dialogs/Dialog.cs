using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TSentler.Dialogs
{
    public class Dialog : MonoBehaviour
    {
        public bool _isInputBack = true;
        public UnityEvent OnEnded;

        private Phrase _phrase; //ссылка на компонент текущей фразы
        private DialogActivator _dialogActivator;
        private DialogView _dialogView;
        private bool _isCurrent;

        private void Awake()
        {
            _phrase = GetComponent<Phrase>(); //с помощью метода GetComponent находим первый рядом лежащий компонент 
            _dialogView = FindObjectOfType<DialogView>(); //ищем компонент DialogView который гдето на сцене(на одном из гейм объектв).
            _dialogActivator = FindObjectOfType<DialogActivator>(); //изначально любая ссылка например _dialogActivator пустая как если бы ей был присвоен null _dialogActivator = null
        }

        public void StartDialog()
        {
            _isCurrent = true;
            Say();
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
                _phrase = _phrase.NextPhrase;
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
                NextPhrase();
            }
        }
    }
}