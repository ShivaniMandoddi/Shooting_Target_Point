using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
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
        Debug.Log(score);
    }
}
