using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    int pipes = 1;
    public GameObject obj;
    void Start()
    {
        StartCoroutine(ISpawn());
    }

    void Update()
    {
        if (pipes > 10)
        {
            var pipe = GameObject.FindGameObjectsWithTag("Pipe");
            for (int i = 0; i < pipe.Length-5; i++)
            {
                Destroy(pipe[i]);
            }
        }
    }
    IEnumerator ISpawn()
    {
        while (true)
        {
            Instantiate(obj,new Vector3(1.5f, Random.Range(-2.7f, 1.7f), 6.35f), Quaternion.identity);
            pipes++;
            yield return new WaitForSeconds(2f);
        }
    }
}
