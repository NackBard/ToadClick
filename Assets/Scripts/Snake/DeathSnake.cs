using UnityEngine;

public class DeathSnake : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var comp = other.gameObject.GetComponent<SnakeMove>();
        Destroy(comp);
    }
}
