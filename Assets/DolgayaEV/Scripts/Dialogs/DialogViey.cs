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
        public GameObject RazvilkaPanel;
        public TMP_Text RazvilkaTextA;
        public TMP_Text RazvilkaTextB;


        private void Awake()
        {
            NameText.text = "";
            MessageText.text = "";
        }

        public void SetFraza(Fraza fraza)
        {
            NameText.text = fraza.Name;
            MessageText.text = fraza.Message;
            RazvilkaPanel.SetActive(false);
            if (fraza is FrazaRazvilka)
            {
                SetFraza(fraza as FrazaRazvilka); 
            }
        }  
        
        private void SetFraza(FrazaRazvilka fraza)
        {
            RazvilkaTextA.text = fraza.ButtonAText;
            RazvilkaTextB.text = fraza.ButtonBText;
            RazvilkaPanel.SetActive(true);
        }
    }
}