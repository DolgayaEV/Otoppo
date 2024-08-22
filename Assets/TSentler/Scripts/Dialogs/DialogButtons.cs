using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler.Dialogs
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
                NextPhrase();
            }
        }

        public void SetDialog(Dialog dialog)
        {
            _currentDialog = dialog;
        }

        public void NextPhrase()
        {
            if (_currentDialog.GetCurrentPhraseFork() != null)
                return;

            _currentDialog.NextPhrase();
        }

        public void PhraseForkA()
        {
            _currentDialog.GetCurrentPhraseFork().SetForkA();
            _currentDialog.NextPhrase();
        }

        public void PhraseForkB()
        {
            _currentDialog.GetCurrentPhraseFork().SetForkB();
            _currentDialog.NextPhrase();
        }
    }
}