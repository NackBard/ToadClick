using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodle : MonoBehaviour
{
    public static Doodle instance;
    public float speed;
    public Rigidbody2D player;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.Translate(new Vector3(Input.acceleration.x * speed * Time.deltaTime, 0, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            
        }
    }
}
