using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler.Dialogs
{
    public class PhraseFork : Phrase
    {
        public Phrase PhraseB;
        public string ButtonAText;
        public string ButtonBText;

        private int _fork; // 0 - ��� ������� �� ������, 1 - ��� ������� � (��� 1), 2 - ��� ������� � (��� 2)

        public override Phrase GetNextPhrase()
        {
            if (_fork == 0)
            {
                throw new System.Exception();
            }

            if (_fork == 1)
            {
                return NextPhrase;
            }
            else
            {
                return PhraseB;
            }
            
        }

        public void SetForkA()
        {
            _fork = 1;
        }

        public void SetForkB()
        {
            _fork = 2;
        }
    }
}