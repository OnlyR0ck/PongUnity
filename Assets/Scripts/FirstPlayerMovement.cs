using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPlayerMovement : MonoBehaviour
{
    #region Fields

    private Rigidbody2D _playerRigidbody2D;
    private float _move;
    private Vector2 _nextPosition;
    private Vector2 _currentPosition;
    private readonly float _border = 3.5f;
    [SerializeField] private float _playerSpeed;
    [SerializeField] [Range(0, 1f)] private float _blend;


    //Input System Assets
    [SerializeField] private InputActionAsset _input;
    private InputActionMap _firstPlayerActionMap;
    private InputAction _firstPlayerMovement;

    #endregion

    private void Awake()
    {
        _firstPlayerActionMap = _input.FindActionMap("1STPlayer");
        _firstPlayerMovement = _firstPlayerActionMap.FindAction("1STMove");
    }

    private void OnEnable()
    {
        _firstPlayerMovement.Enable();
    }


    private void OnDestroy()
    {
        _firstPlayerMovement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        _currentPosition = transform.position;

        if (Mathf.Abs(_currentPosition.y) <= _border)
        {
            _move = _firstPlayerMovement.ReadValue<float>() * _playerSpeed * Time.deltaTime;
            _nextPosition = new Vector2(_currentPosition.x, _currentPosition.y + _move);

            transform.position = Vector2.Lerp(_currentPosition, _nextPosition, _blend);
        }
        else if (_currentPosition.y > 0) transform.position = new Vector3(transform.position.x, _border);
        else transform.position = new Vector3(transform.position.x, -_border);
    }
}
