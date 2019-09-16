using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float _speed;
    private Rigidbody _rigidBody;
    private Vector3 _movement;

    private Vector3 _startPosition;

    public Vector3 StartPosition
    {
        get
        {
            return _startPosition;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = _movement * _speed;
    }
}
