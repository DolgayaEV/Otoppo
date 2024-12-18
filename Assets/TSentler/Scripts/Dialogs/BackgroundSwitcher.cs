using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler.Dialogs
{
    public class BackgroundSwitcher : MonoBehaviour
    {
        public List<GameObject> Backgrounds = new List<GameObject>();

        private void Awake()
        {
            DeactivateAll();
        }

        public void ActivateByIndex(int index)
        {
            if (index == -1)
                return;

            if (index == -2)
            {
                DeactivateAll();
                return;
            }

            DeactivateAll();
            Backgrounds[index].SetActive(true);
        }

        public void DeactivateAll()
        {
            Backgrounds.ForEach(a => a.SetActive(false));
        }
    }
}