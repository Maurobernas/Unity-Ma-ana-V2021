using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementC13
{
    private PlayerC13 _player;
    private Transform _transform;
    private Rigidbody _rigidBody;
    private float _speed;
    private float _jumpForce;
    private bool _ground;

    public PlayerMovementC13(Transform transform, float speed, Rigidbody rigidbody, float jumpForce, PlayerC13 player)
    {
        _transform = transform;
        _rigidBody = rigidbody;
        _speed = speed;
        _jumpForce = jumpForce;
        _player = player;
    }

    public void Direction(float horizontal, float vertical)
    {
        //Vector3 vectorSpeed = (horizontal * _transform.right + vertical * _transform.forward).normalized * _speed;
        Vector3 vectorSpeed = (horizontal * _transform.right + vertical * _transform.forward).normalized * _player.Speed;
        // _animation.SetFloat("Walking", horizontal, vertical);

        Moving(vectorSpeed);
    }

    private void Moving(Vector3 direction)
    {
        _rigidBody.velocity = direction.x * Vector3.right + _rigidBody.velocity.y * Vector3.up + direction.z * Vector3.forward;
    }

    public void Jump()
    {
        if (_ground)
        {
            //_rigidBody.AddForce(_transform.up * _jumpForce, ForceMode.Impulse);
            _rigidBody.AddForce(_transform.up * _player.JumpForce, ForceMode.Impulse);
            _ground = false;
        }
    }

    public bool Ground { set { _ground = value; } }
}
