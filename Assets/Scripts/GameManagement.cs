using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scoreText;
    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
