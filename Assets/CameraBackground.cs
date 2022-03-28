using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] colors = new Color[5];
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 3f)
        {

            int x = Random.Range(0, 5);
            Camera.main.backgroundColor = colors[x];
            time = 0f;
        }
        
    }
}
