using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV
{
    public class DialogActivator : MonoBehaviour
    {
        public GameObject Dialog;
        public CharacterControls CharacterControls;

        private void Awake()
        {
            CharacterControls = FindObjectOfType<CharacterControls>();
            Dialog.SetActive(false); 
        }

        public void Activate()
        {
            CharacterControls.DialogActivate();
            Dialog.SetActive(true);
        }
    }
}