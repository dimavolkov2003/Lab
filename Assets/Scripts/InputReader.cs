using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
public class InputReader : MonoBehaviour
{
    [SerializeField] private PlayerEntity _playerEntity;
    private float _horizontalDirection;
    private float _verticalDirection;

    // Update is called once per frame
    private void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");
        _verticalDirection = Input.GetAxisRaw("Vertical");
        if(Input.GetButtonDown("Jump"))
            _playerEntity.Jump();
    }
    private void FixedUpdate() 
    {
        _playerEntity.MoveHorizontally(_horizontalDirection);
        _playerEntity.MoveVertically(_verticalDirection);
    }
}
