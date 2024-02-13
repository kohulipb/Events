using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameManager", menuName = "Managers/GameManager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] EventManagerSO eventManager;
    public int coins = 0;
    public int coinsNeeded = 5;

    private void OnEnable()
    {
        eventManager.onCoinCollected += AddCoin;
    }
    private void OnDisable()
    {
        eventManager.onCoinCollected -= AddCoin;

    }
    private void AddCoin()
    {
        coins++;
    }
}
