using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
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
        _text.text = $"Score: {_playerBag.Score}";
    }
}