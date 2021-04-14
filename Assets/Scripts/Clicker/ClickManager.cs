using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public Button Toatbutton;
    public Text toat;
    public Sprite GreenImage;
    public Sprite RedImage;
    public GameObject shopPanel, miniGamePanel;
    public Text hunter;
    public Text ferm;

    public void Start()
    {
        Toatbutton = Toatbutton.GetComponent<Button>();
    }
    public void OnClick()
    {
        int i = Convert.ToInt32(toat.text);
        i++;
        toat.text = i.ToString();
        Toatbutton.image.sprite = GreenImage;
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        Toatbutton.image.sprite = RedImage;
    }

    public void ClickAddShopPanel()
    {
        shopPanel.SetActive(true);
    }

    public void ClickDelShopPanel()
    {
        shopPanel.SetActive(false);
    }

    public void BuyHunter()
    {
        int money = Convert.ToInt32(toat.text);
        int hunterCount = Convert.ToInt32(hunter.text);
        int price = 100 + hunterCount * 20;
        if (money >= price)
        {
            money -= price;
            toat.text = money.ToString();
            hunter.text = (Convert.ToInt32(hunter.text) + 1).ToString();
            PlayerPrefs.SetInt("hunters", Convert.ToInt32(hunter.text));
            PlayerPrefs.Save();
        }
    }

    public void BuyFerm()
    {
        int money = Convert.ToInt32(toat.text);
        int fermCount = Convert.ToInt32(ferm.text);
        int price = 300 + fermCount * 100;
        if (money >= price)
        {
            money -= price;
            toat.text = money.ToString();
            ferm.text = (Convert.ToInt32(ferm.text) + 1).ToString();
            PlayerPrefs.SetInt("ferms", Convert.ToInt32(ferm.text));
            PlayerPrefs.Save();
        }
    }

    public void MiniGameButton()
    {
        miniGamePanel.SetActive(true);
    }

    public void Clicker()
    {
        miniGamePanel.SetActive(false);
    }

    public void SnakeGame()
    {
        SceneManager.LoadScene("SnakeScene");
    }
}
