using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler
{
    public class InputReturner : MonoBehaviour
    {
        private CharacterControls _characterControls;
        private DialogActivator _dialogActivator;

        private void Awake()
        {
            _characterControls = FindObjectOfType<CharacterControls>();
            _dialogActivator = FindObjectOfType<DialogActivator>();
            _dialogActivator.Activated.AddListener(InputActivate);
            _dialogActivator.Deactivated.AddListener(InputDeactivate);
        }

        private void InputActivate()
        {
            _characterControls.DialogActivate(); //сообщаем классу управлению движени персонажа CharacterControls,
        }

        private void InputDeactivate()
        {
            _characterControls.DialogDeactivate();
        }
    }
}