using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform doodlePos;
    void Update()
    {
        if (doodlePos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, doodlePos.position.y, transform.position.z);
        }
    }
}
