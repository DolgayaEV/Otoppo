using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
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
            CharacterControls.DialogActivate(); //сообщаем классу управлению движени персонажа CharacterControls,
            //о тьом что запускаеться диалоговое окно. Остановить управление персонажа
            Dialog.SetActive(true); //активируем геймобьекта Канваса Диалогов.
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