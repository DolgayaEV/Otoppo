using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TSentler.Dialogs
{
    public class Phrase : MonoBehaviour
    {
        public string Name;
        public string Message;
        public Camera Camera;
        public Phrase NextPhrase;
        public int BackgroundIndex = -1;
        public Sprite ImageHead;
        public UnityEvent OnStarted;

        public virtual Phrase GetNextPhrase()
        {
            return NextPhrase;
        }
    }
}