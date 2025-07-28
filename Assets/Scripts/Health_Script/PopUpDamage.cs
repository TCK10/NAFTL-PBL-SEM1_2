using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpDamage : MonoBehaviour
{
    public Vector2 InitialVelovity;
    public float lifetime = 1.5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = InitialVelovity;
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
            
    }
}
