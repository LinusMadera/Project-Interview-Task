using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    Rigidbody2D _rigidbody2D;

    Animator _animator;

    float x, y; 

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        _rigidbody2D.MovePosition(_rigidbody2D.position + new Vector2(x, y) * _speed * Time.deltaTime);

        _animator.SetFloat("XBlend", x);
        _animator.SetFloat("YBlend", y);
        _animator.SetFloat("SpeedBlend", x * x + y * y);
    }

}
