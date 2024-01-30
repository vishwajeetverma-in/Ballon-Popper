using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public int score;
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] private BallonController ballonController;

    private void Awake()
    {
        score = 0;
    }

    private void OnEnable()
    {
        // Subscribing event
        ballonController.MouseClickEvent += AddScore;
        ballonController.MouseClickEvent += UpdateScore;
    }

    private void OnDisable()
    {
        // Unsubscribe Event
        ballonController.MouseClickEvent += AddScore;
        ballonController.MouseClickEvent += UpdateScore;
    }

    public void AddScore()
    {
        score++;
    }

    public void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
}
