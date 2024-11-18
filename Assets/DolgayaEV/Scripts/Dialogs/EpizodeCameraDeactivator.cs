using UnityEngine;

namespace DolgayaEV.Dialogs
{
    public class EpizodeCameraDeactivator : MonoBehaviour
    {
        private void Awake()
        {
            Camera[] chilsds = transform.GetComponentsInChildren<Camera>();
            foreach (Camera item in chilsds)
            {
                item.gameObject.SetActive(false);
                Debug.Log(item.name);
            }
        }
    }
}