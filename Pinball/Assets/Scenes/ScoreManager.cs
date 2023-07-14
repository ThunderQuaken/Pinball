using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    public int score = 0;
    int displayScore = 0;
    double waitTime = .03;
    double waitedTime = 0;


    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = displayScore.ToString();
    }

    // Update is called once per frame
    public void AddPoint(int amount)
    {
        score += amount;
    }

    private void Update()
    {
        if (displayScore < score)
        {
            if (waitedTime >= waitTime)
            {
                displayScore += (int)(System.Math.Sqrt(score - displayScore) + 1);
                scoreText.text = displayScore.ToString();
                waitedTime = 0;
            } else
            {
                waitedTime += Time.deltaTime;
            }
        } else if (displayScore > score)
        {
            displayScore = score;
            scoreText.text = displayScore.ToString();
        }
    }

    public void deactivate()
    {
        gameObject.SetActive(false);
    }

}
