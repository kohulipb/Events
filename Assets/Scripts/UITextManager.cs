using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextManager : MonoBehaviour
{
    [SerializeField] EventManagerSO eventManager;
    [SerializeField] GameManagerSO gameManager;

    [SerializeField] TMP_Text text;
    [SerializeField] TMP_Text mission;

    private void OnEnable()
    {
        eventManager.onCoinCollected += UpdateScore;
    }
    private void OnDisable()
    {
        eventManager.onCoinCollected -= UpdateScore;
    }

    private void Awake()
    {
        UpdateScore();
    }
    private void UpdateScore()
    {
        text.text = $"Scrimblo tokens: {gameManager.coins}";
    }
}
