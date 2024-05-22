using UnityEngine;

public class PlayerAnimationPresenter : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private string _toIdleName = "ToIdle";
    [SerializeField] private string _toRunName = "ToRun";
    [SerializeField] private string _toJumpName = "ToJump";
	[SerializeField] private float _minIdleSpeed = 1f;

	private float _distToGround;
	private bool _isJumped, _isRun, _isIdle;

	private void  Start (){
		// get the distance to ground
		_distToGround = GetComponent<Collider>().bounds.extents.y;
	}

	private void Update()
	{
		var velocityXZ =
			new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z)
			.magnitude;
		
		if (IsGrounded())
		{
			_animator.ResetTrigger(_toJumpName);
			_isJumped = false;
			if (velocityXZ > _minIdleSpeed)
			{
				_isIdle = false;
				if (_isRun == false)
				{
					_animator.ResetTrigger(_toIdleName);
					_animator.ResetTrigger(_toRunName);
					_animator.SetTrigger(_toRunName);
					_isRun = true;
				}
			}
			else
			{
				_isRun = false;
				if (_isIdle == false)
				{
					_animator.ResetTrigger(_toIdleName);
					_animator.ResetTrigger(_toRunName);
					_animator.SetTrigger(_toIdleName);
					_isIdle = true;
				}
			}
		}
		else
		{
			_isIdle = false;
			_isRun = false;
			if (_isJumped == false)
			{
				_animator.SetTrigger(_toJumpName);
				_isJumped = true;
			}
		}
	}

	private bool IsGrounded (){
		return Physics.Raycast(transform.position, -Vector3.up, _distToGround + 0.1f);
	}
	
	
}
