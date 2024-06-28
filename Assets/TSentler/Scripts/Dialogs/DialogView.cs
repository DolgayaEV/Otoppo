using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TSentler.Dialogs
{
    public class DialogView : MonoBehaviour
    {
        public TMP_Text NameText;
        public TMP_Text MessageText;

        private void Awake()
        {
            NameText.text = "";
            MessageText.text = "";
        }

        public void SetPhrase(Phrase phrase)
        {
            NameText.text = phrase.Name;
            MessageText.text = phrase.Message;
        }
    }
}