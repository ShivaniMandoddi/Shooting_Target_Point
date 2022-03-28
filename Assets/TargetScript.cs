using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreCalculator scoreCalculator;
    void Start()
    {
        scoreCalculator = GameObject.Find("ScoreManager").GetComponent<ScoreCalculator>();
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        scoreCalculator.Score(1);
    }
}
