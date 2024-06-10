using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DolgayaEV
{
    public class NekstLevelButtoms : MonoBehaviour
    {
        public string LevelName;

      public void Next()
        {
            SceneManager.LoadScene(LevelName);
        }  
    }
}