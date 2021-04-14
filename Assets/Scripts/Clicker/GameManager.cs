using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text toat;
    public Text hunter;
    public Text ferm;
    void Start()
    {
        toat.text = PlayerPrefs.GetInt("money").ToString();
        hunter.text = PlayerPrefs.GetInt("hunters").ToString();
        ferm.text = PlayerPrefs.GetInt("ferms").ToString();

        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            int money = Convert.ToInt32(toat.text);
            money = (int)(money + (1 * Convert.ToInt32(hunter.text)) + (10 * Convert.ToInt32(ferm.text)));
            toat.text = money.ToString();
            yield return new WaitForSeconds(1f);
            PlayerPrefs.SetInt("money", Convert.ToInt32(toat.text));
            PlayerPrefs.Save();
        }
    }
}
