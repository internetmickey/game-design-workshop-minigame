using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour
{
    public float score;
    public float pointsPerSec = 1f;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += pointsPerSec * Time.smoothDeltaTime;
        scoreText.text = "Score:" + score;
    }
}
