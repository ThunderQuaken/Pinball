using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballManager : MonoBehaviour
{
    public GameObject Pinball;
    public GameObject pinballCabinet;
    public GameOverActivate gameOverActivate;

    public static PinballManager instance;

    float ScoreNeeded = 1500;
    float livingPinballs = 0;

    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        CreatePinball();
    }

    void CreatePinball()
    {
        GameObject pinball = Instantiate(Pinball);
        pinball.transform.parent = pinballCabinet.transform;
        livingPinballs++;
    }

    public void DestroyPinball()
    {
        livingPinballs--;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreNeeded < ScoreManager.instance.score)
        {
            CreatePinball();
            ScoreNeeded *= 2;
        }

        if (livingPinballs == 0)
        {
            gameOverActivate.Activate(ScoreManager.instance.score);
        }
    }
}
