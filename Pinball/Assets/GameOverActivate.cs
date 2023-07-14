using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverActivate : MonoBehaviour
{

    public TextMeshProUGUI pointsText;

    public void Activate(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString();
        ScoreManager.instance.deactivate();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainPinball");
    }
}
