using System;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    private Vector2 _startDirection;
    private Rigidbody2D _ballRigidbody2D;

    [SerializeField] private float _ballSpeed;
    private const float LeftBorder = 8.35f;
    
    [SerializeField] private InputActionAsset _input;
    private InputActionMap _ballPlayerActionMap;
    private InputAction _ballPlayerMovement;
    
    public static event Action<bool> IsGoal;
    
    private void Awake()
    {
        _ballPlayerActionMap = _input.FindActionMap("Ball");
        _ballPlayerMovement = _ballPlayerActionMap.FindAction("Reset");

        _ballPlayerMovement.performed += BallAddForce;
    }

    private void OnEnable()
    {
        _ballPlayerMovement.Enable();
    }

    private void OnDisable()
    {
        _ballPlayerMovement.Disable();
    }

    private void Start()
    {
        _ballRigidbody2D = GetComponent<Rigidbody2D>();
        BallReset();
    }

    private void BallReset()
    {
        transform.position = Vector3.zero;
        _ballRigidbody2D.velocity = Vector2.zero;
    }

    private void BallAddForce(InputAction.CallbackContext obj)
    {
        Vector2 direction = new Vector2(1, Random.Range(0.5f, 1f));
        if (Random.Range(0, 2) == 1) direction *= -1;
        _ballRigidbody2D.velocity = direction * _ballSpeed;
    }

    private void Update()
    {
        CheckForCollisions();
        
    }

    private void CheckForCollisions()
    {
        if (!(Mathf.Abs(transform.position.x) > LeftBorder)) return;
        
        IsGoal?.Invoke(transform.position.x > 0);
        BallReset();
    }

    /*private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("First"))
        {
            _isGoal?.Invoke(true);
            BallReset();
        }
        else if (other.collider.CompareTag("Second"))
        {
            _isGoal?.Invoke(false);
            BallReset();
        }
    }*/
}
