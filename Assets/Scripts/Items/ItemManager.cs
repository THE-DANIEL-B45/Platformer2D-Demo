using Ebac.Core.Singleton;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    public TextMeshProUGUI coinsText;

    public int coins;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
        coinsText.text = "x0";
    }

    public void AddCoins(int amount = 1)
    {
        coins += amount;
        coinsText.text = "x" + coins.ToString();
    }
}
