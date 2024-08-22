using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV.Dialogs
{
    public class BeckgraunPereklychi : MonoBehaviour
    {
        public List <GameObject> Backgrounds = new List <GameObject> ();

        private void Awake()
        {
            DiactivateAll();
        }

        public void ActivateByIndex(int index)
        {
            if (index == -1)
                return;

            if (index == -2)
            {
                DiactivateAll();
                return;
            }

            DiactivateAll();
            Backgrounds[index].SetActive(true);
        }
            

        public void DiactivateAll()
        {
            Backgrounds.ForEach(a => a.SetActive(false));
        }
    }
}