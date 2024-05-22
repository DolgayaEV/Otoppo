using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrikunLS
{
    public class LogicIf : MonoBehaviour
    {
        public bool KeyRed;
        public bool KeyGreen;

       private void Start()
        {
            //можно использовать && и || вместе - тогда у & будет приоритет над || как у * перед +
            And();
            Or();
        }

        private void Or()
        {
            if (KeyRed == true)
            {
                Debug.Log("Open!");
            }
            else if (KeyGreen == true)
            {
                Debug.Log("Open!");
            }

            if (KeyGreen == true || KeyRed == true)// подразумевыает выполнение хотя бы одного условия - если первое выполнено, то последующие даже не будет проверять || - знак логическая "или" (1+1)
            {
                Debug.Log("Open!");
            }
        }

        private void And()
        {
            if (KeyRed == true)
            {
                if (KeyGreen == true)
                {
                    Debug.Log("Open!");
                }
            }

            if (KeyRed == true && KeyGreen == true) //&& - логическая "и", проверяющая выполнение одновременно несколько условий (1*1)
            {
                Debug.Log("Open!");
            }
        }

        private void Update()
        {
        
        }
    }

}