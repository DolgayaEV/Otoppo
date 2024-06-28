using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharAnim : MonoBehaviour
{
    public Animator Anim;
    public UnityEvent Movie;
    public bool IsMovie;

    void Start()
    {
        if (IsMovie)
        {
            Movie.Invoke();
        }
        else
        {
            Anim.SetTrigger("ToDie");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
