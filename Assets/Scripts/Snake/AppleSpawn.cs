using UnityEngine;

public class AppleSpawn : MonoBehaviour
{
    public GameObject apple;
    void Start()
    {
        Instantiate(apple, new Vector3(Random.Range(-20, 19), Random.Range(-4, 25), 30.01f), Quaternion.identity);
    }

}