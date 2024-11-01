using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

namespace DolgayaEV.Dialogs
{
    public class DialogViey : MonoBehaviour
    {
        public TMP_Text NameText;
        public TMP_Text MessageText;
        public GameObject RazvilkaPanel;
        public TMP_Text RazvilkaTextA;
        public TMP_Text RazvilkaTextB;
        public Image ImageHead;



        private void Awake()
        {
            NameText.text = "";
            MessageText.text = "";
        }

        public void SetFraza(Fraza fraza)
        {
            NameText.text = fraza.Name;
            MessageText.text = fraza.Message;
            if (fraza.ImageHead != null)
            {
                ImageHead.sprite = fraza.ImageHead;
            }
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