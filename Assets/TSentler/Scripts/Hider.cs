using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSentler
{
    public class Hider : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.SetActive(false);
        }
    }
}