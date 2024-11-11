using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationOffset : MonoBehaviour
{
    [SerializeField, Range(0f,1f)] private float _offset;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        int stateHash = _animator.GetCurrentAnimatorStateInfo(0).shortNameHash;
        _animator.Play(stateHash, 0, _offset);

    }
}
