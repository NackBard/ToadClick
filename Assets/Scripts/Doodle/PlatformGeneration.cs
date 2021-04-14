using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public int MaxNumPlatforms;
    private int NumPlatforms = 1;
    public GameObject platform;
    private Vector3 LeftSceneCoord, MainSceneCoord, RightSceneCoord;

    private void Start()
    {
        LeftSceneCoord = new Vector3();
        MainSceneCoord = new Vector3();
        RightSceneCoord = new Vector3();
    }
    void Update()
    {
        if (NumPlatforms < MaxNumPlatforms)
        {
            float x = Random.Range(-2.2f, 2.2f);
            float y = Random.Range(1f, 2f);
            MainSceneCoord.x = x;
            MainSceneCoord.y += y;
            RightSceneCoord.x = MainSceneCoord.x - 5.6f;
            RightSceneCoord.y = MainSceneCoord.y;
            LeftSceneCoord.x = MainSceneCoord.x + 5.6f;
            LeftSceneCoord.y = MainSceneCoord.y;

            Instantiate(platform, MainSceneCoord, Quaternion.identity);
            Instantiate(platform, RightSceneCoord, Quaternion.identity);
            Instantiate(platform, LeftSceneCoord, Quaternion.identity);

            NumPlatforms++;
        }
    }
}
