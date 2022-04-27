using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMove;

    private void Awake()
    {
        _playerMove = GetComponent<PlayerMovementBehavior>();
    }

    private void Update()
    {
        _playerMove.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
    }
}
