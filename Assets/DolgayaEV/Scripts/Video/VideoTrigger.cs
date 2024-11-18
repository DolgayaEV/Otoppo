using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

namespace DolgayaEV.Video
{
    public class VideoTrigger : MonoBehaviour
    {
        public VideoPlayer VideoPlayer;
        public UnityEvent VideoStopped;

        private bool isStarted;

        private void Awake()
        {
            VideoPlayer.started += (VideoPlayer source) => isStarted = true;
        }

        private void Update()
        {
            if (isStarted && VideoPlayer.isPlaying == false)
            {
                VideoStopped.Invoke();
            }
        }
    }
}