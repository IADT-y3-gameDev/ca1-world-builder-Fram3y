using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set; }

    public UnityEvent<PlayerInventory> OnCoinCollected;

    public void CoinCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }
}
