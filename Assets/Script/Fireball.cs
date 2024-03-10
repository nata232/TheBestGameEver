﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;

    private void Start()
    {
        Invoke("DestroyFireball", lifetime);
    }
    void FixedUpdate()
    {
        MoveFixedUpdate();
    }
    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        DestroyFireball();
        
    }
    private void DestroyFireball()
    {
        Destroy(gameObject);
    }
}
