using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    private Vector2 _startDirection;
    private Rigidbody2D _ballRigidbody2D;

    [SerializeField] private float _ballSpeed;
    private const float LeftBorder = 8.35f;
    
    public static event Action<bool> IsGoal;

    private void Start()
    {
        _ballRigidbody2D = GetComponent<Rigidbody2D>();
        BallReset();
    }

    private void BallReset()
    {
        transform.position = Vector3.zero;
        _ballRigidbody2D.velocity = Random.insideUnitCircle * _ballSpeed;
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
