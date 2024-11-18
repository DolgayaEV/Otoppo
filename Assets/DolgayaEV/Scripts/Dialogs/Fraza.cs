using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace DolgayaEV.Dialogs
{

    public class Fraza : MonoBehaviour
    {
        public int Index = -1;

        public string Name;
        public string Message;
        public Camera Camera;
        public Fraza NextFraza;
        public int BackgroundIndex = -1;
        public Sprite ImageHead;
        public UnityEvent OnStarted;

        private void OnValidate()
        {
            if (Index == -1)
            {
                List<Fraza> frazes = GetComponents<Fraza>().ToList<Fraza>();
                Index = frazes.FindIndex(match => match.Equals(this));

            }
        }

        public virtual Fraza GetNextFraza()
        {
            return NextFraza;
        }

        public void Log()
        {
            string path = transform.parent?.name ?? "";
            path += "\\" + transform.name + "\\";
            Debug.LogWarning("Next is " + path + Index, this);
            if (Camera != null)
            {
                Debug.LogWarning("Current camera " + Camera, Camera);
            }
        }
    }
}