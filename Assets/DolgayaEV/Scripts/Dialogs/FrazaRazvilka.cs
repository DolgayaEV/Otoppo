using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DolgayaEV.Dialogs
{
    public class FrazaRazvilka : Fraza
    {
        public Fraza FrazaB;
        public string ButtonAText;
        public string ButtonBText;

        private int _vybor; // 0 - ������� �� ������, 1 - ������� �, 2 ������� - �.
        
        public override Fraza GetNextFraza()
        {
            if (_vybor == 0)
            {
                throw new System.Exception();
            }
            if (_vybor == 1)
            {
                return NextFraza;
            } 
            else 
            {
                return FrazaB;
            }


        }
    }
}