using System;
using UnityEngine;

public class PlayerBag : MonoBehaviour
{
    public GameAudio GameAudio;
    public int Score { get; private set; }

    public event Action Updated;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Score++;
            Destroy(other.gameObject);
            UpdateTotalScore();
            GameAudio.PlayStarSound();
            Updated?.Invoke();
        }
    }

    private void UpdateTotalScore()
    {
        int totalScore = 0;
        if(PlayerPrefs.HasKey("TotalScore"))
            totalScore = PlayerPrefs.GetInt("TotalScore");

        totalScore++;
        PlayerPrefs.SetInt("TotalScore", totalScore);
    }
}