using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler.Dialogs
{
    public class Phrase : MonoBehaviour
    {
        public string Name;
        public string Message;
        public Camera Camera;
        public Phrase NextPhrase;

        public virtual Phrase GetNextPhrase()
        {
            return NextPhrase;
        }
    }
}