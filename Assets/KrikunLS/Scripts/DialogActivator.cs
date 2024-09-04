using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KrikunLS
{
    public class DialogActivator : MonoBehaviour
    {
        public GameObject Dialog;

        public UnityEvent Activated;
        public UnityEvent Deactivated;

        private void Awake()
        {
            Dialog.SetActive(false);
        }

        public void Activate()
        {
            Dialog.SetActive(true); // активация геймобъекта (панель диалогов) - включает галочку
            Activated.Invoke(); 
        }
        public void Deactivate(bool isEventNeed)
        {
            if (isEventNeed)
            {
                Deactivated.Invoke();   
            }
            Dialog.SetActive(false);
        }
    }
}