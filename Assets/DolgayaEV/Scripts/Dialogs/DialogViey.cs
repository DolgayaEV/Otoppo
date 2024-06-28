using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

namespace DolgayaEV.Dialogs
{
    public class DialogViey : MonoBehaviour
    {
        public TMP_Text NameText;
        public TMP_Text MessageText;

        private void Awake()
        {
            NameText.text = "";
            MessageText.text = "";
        }

        public void SetFraza(Fraza fraza)
        {
            NameText.text = fraza.Name;
            MessageText.text = fraza.Message;
        }
    }
}