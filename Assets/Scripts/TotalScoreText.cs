using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class TotalScoreText : MonoBehaviour
{
    [SerializeField]
    private PlayerBag _playerBag;

    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _playerBag.Updated += UpdateText;
        UpdateText();
    }

    private void OnDestroy()
    {
        _playerBag.Updated -= UpdateText;
    }

    private void UpdateText()
    {
        int totalScore = 0;
        if(PlayerPrefs.HasKey("TotalScore"))
            totalScore = PlayerPrefs.GetInt("TotalScore");
        
        _text.text = $"Total score: {totalScore}";
    }
}