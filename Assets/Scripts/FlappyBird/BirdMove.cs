using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public Rigidbody2D rd;
    public float force;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rd.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
}
