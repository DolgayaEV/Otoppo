using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler
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
            CharacterControls.DialogActivate(); //Сообщаем классу управления движением перса, о том что открывается диалоговое окно и он должен отрубить управление игроком.
            Dialog.SetActive(true); //Активация геймобъекта с канвасом диалогов
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