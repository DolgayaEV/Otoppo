using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DolgayaEV.Dialogs
{

    public class Fraza : MonoBehaviour
    {
        public string Name;
        public string Message;
        public Camera Camera;
        public Fraza NextFraza;
        public int BackgroundIndex = -1;
        public Sprite ImageHead;
        public UnityEvent OnStarted;

        public virtual Fraza GetNextFraza()
        {
            return NextFraza;
        } 
        
    }
}