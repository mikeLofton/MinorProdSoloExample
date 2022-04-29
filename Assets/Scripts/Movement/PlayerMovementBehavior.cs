using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector3 _startPos;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _startPos = transform.position;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = MoveDirection * _speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Snowball")
        {
            transform.position = _startPos;
        }
    }
}
