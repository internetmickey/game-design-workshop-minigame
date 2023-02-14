using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private float outOfBounds = -25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < outOfBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
