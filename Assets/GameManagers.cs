using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public GameObject targetPrefab;
    ScoreCalculator scoreCalculator;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 1f, 1f);
        scoreCalculator = GameObject.Find("ScoreManager").GetComponent<ScoreCalculator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Spawner();
        if (scoreCalculator.IsGameOver == true)
        {
            CancelInvoke("Spawner");
        }
    }

    private void Spawner()
    {
        float randomX = UnityEngine.Random.Range(-4.5f, 3.6f);
        float randomY = UnityEngine.Random.Range(-2.17f, 2.1f);
        Instantiate(targetPrefab, new Vector3(randomX, randomY, 0f), Quaternion.identity);


    }
}
