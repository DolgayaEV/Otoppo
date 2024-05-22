using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
    public UnityEvent OnEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //teleport.Apply(other.transform);
            OnEnter.Invoke();
        }

        string gestName = other.gameObject.name;
        string tager = other.gameObject.tag;
        Debug.Log("Тук от " + gestName + " Под тегом" + tager);
        Debug.Log(name);
    }

}
