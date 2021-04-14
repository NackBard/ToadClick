using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public BoxCollider2D box;
    // Start is called before the first frame update
    private void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        box.isTrigger = false;
        var fall = collision.gameObject.GetComponent<BirdMove>();
        Destroy(fall);
    }
}
