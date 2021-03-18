using System;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _firstPlayerScoreText;
    [SerializeField] private TextMeshProUGUI _secondPlayerScoreText;

    private int _firstPlayerScore = 0;
    private int _secondPlayerScore = 0;

    private void OnEnable()
    {
        BallController.IsGoal += UpdateScore;
    }

    private void OnDisable()
    {
        BallController.IsGoal -= UpdateScore;
    }

    private void UpdateScore(bool winner)
    {
        if (winner)
        {
            _firstPlayerScoreText.text = $"{++_firstPlayerScore}";
        }
        else _secondPlayerScoreText.text = $"{++_secondPlayerScore}";
    }
}
