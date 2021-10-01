using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    //converts the int score to a string variable to show it onscreen
    public void SetScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
