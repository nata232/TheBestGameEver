using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private float _fallVelocity = 0;
    public float gravity = 9.8f;
    

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    
    void FixedUpdate()
    {
        _fallVelocity += gravity + Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

    }
}
