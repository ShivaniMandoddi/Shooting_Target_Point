using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;
    public GameObject winPage;
    public bool IsGameOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Score(int scoreValue)
    {
        score = score + scoreValue;
        scoreText.text = "Score: " + score;
        if(score>=20)
        {
            winPage.SetActive(true);
            IsGameOver = true;
        }
        Debug.Log(score);
    }
}
