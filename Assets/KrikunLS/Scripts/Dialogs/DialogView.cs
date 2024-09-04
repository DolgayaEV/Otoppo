using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KrikunLS.Dialogs
{
    public class DialogView : MonoBehaviour
    {
        public TMP_Text NameText;
        public TMP_Text MessageText;
        public GameObject ButtonsPanel;
        public TMP_Text TextButtonA;
        public TMP_Text TextButtonB;
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
            ButtonsPanel.SetActive(false);
            if (fraza is FrazaRazvilka)
            {
                SetFraza(fraza as FrazaRazvilka);
            }
        }

        private void SetFraza(FrazaRazvilka fraza)
        {
            TextButtonA.text = fraza.A;
            TextButtonB.text = fraza.B;
            ButtonsPanel.SetActive(true);
        }
    }
}