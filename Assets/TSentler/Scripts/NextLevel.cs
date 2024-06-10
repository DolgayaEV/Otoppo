using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TSentler
{
    public class NextLevel : MonoBehaviour
    {
        public string LevelName;

        public void Next()
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}