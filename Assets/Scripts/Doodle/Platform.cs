using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float force = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Doodle.instance.player.velocity = Vector2.up * force;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-5f, 5f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
