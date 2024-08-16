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
        public GameObject ForkPanel;
        public TMP_Text ForkTextA;
        public TMP_Text ForkTextB;

        private void Awake()
        {
            NameText.text = "";
            MessageText.text = "";
        }

        public void SetPhrase(Phrase phrase)
        {
            NameText.text = phrase.Name;
            MessageText.text = phrase.Message;
            ForkPanel.SetActive(false);
            if (phrase is PhraseFork)
            {
                SetPhrase(phrase as PhraseFork);
            }
        }

        private void SetPhrase(PhraseFork phrase)
        {
            ForkTextA.text = phrase.ButtonAText;
            ForkTextB.text = phrase.ButtonBText;
            ForkPanel.SetActive(true);
        }
    }
}