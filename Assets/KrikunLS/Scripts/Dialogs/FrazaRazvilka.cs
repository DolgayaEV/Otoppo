using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrikunLS.Dialogs
{
    public class FrazaRazvilka : Fraza
    {
        public Fraza FrazaB;
        public string A;
        public string B;

        private int _Vybor; //0-это вариант не выбран, 1- вариант А, 2-вариант В
        public override Fraza GetNextFraza()
        {
            if (_Vybor==0)
            {
                throw new System.Exception();
            }
            if (_Vybor==1)
            {
                return NextFraza;
            }
            else
            {
                return FrazaB;
            }
        }

        public void SetRazvilkaA()
        {
            _Vybor = 1;
        }

        public void SetRazvilkaB()
        {
            _Vybor = 2;
        }
    }
}