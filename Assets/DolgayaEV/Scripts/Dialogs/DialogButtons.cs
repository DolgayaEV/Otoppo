using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV.Dialogs
{
    public class DialogButtons : MonoBehaviour
    {
        private Dialog _currentDialog;

        private void Update() // отслеживание нажатия кнопки пробел 
        {
            if (_currentDialog == null)
                return;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextFraza();
            }
        }

        public void SetDialog(Dialog dialog)
        {
            _currentDialog = dialog;
        }
        public void NextFraza()
        {
            if (_currentDialog.GetCurrentFrazaRazvilka() != null)
                return;

            _currentDialog.NextFraza();
        }

        public void FrazaRazvilkaA()
        {
            _currentDialog.GetCurrentFrazaRazvilka().SetRazvilkaA();
            _currentDialog.NextFraza();
        }

        public void FrazaRazvilkaB()
        {
            _currentDialog.GetCurrentFrazaRazvilka().SetRazvilkaB();
            _currentDialog.NextFraza();
        }
    }
}