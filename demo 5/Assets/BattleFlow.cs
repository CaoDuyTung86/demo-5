using System;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;

    void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);

        playerHealth.onDead += OnGameOver;
    }

    private void OnGameOver()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }
}