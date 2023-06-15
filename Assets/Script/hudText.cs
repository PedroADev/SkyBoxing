using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hudText : MonoBehaviour
{

    public TMPro.TextMeshProUGUI score;
    private int currentScore = 0;
    float currentTime;
    float timeBetweenTaps = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentTime += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && currentTime >= timeBetweenTaps)
        {
            currentScore += 1;
            score.text = ("Pontos : ") + currentScore.ToString();
            PlayerPrefs.SetInt("currentScore", currentScore);
            currentTime = 0.0f;
        }

    }
}
