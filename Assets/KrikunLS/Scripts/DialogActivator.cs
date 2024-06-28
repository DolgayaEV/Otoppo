using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrikunLS
{
    public class DialogActivator : MonoBehaviour
    {
        public GameObject Dialog;

        private CharacterControls CharacterControls;

        private void Awake()
        {
            CharacterControls = FindObjectOfType<CharacterControls>();
            Dialog.SetActive(false);
        }

        public void Activate()
        {
            CharacterControls.DialogActivate(); // сообщаем классу управления движением персонажа о том, что открывается диалоговое окно и ему необходимо отключить управление персонажем
            Dialog.SetActive(true); // активация геймобъекта (панель диалогов) - включает галочку   
        }
        public void Deactivate(bool isInputBack)
        {
            if (isInputBack)
            {
                CharacterControls.DialogDeactivate();
            }
            Dialog.SetActive(false);
        }
    }
}