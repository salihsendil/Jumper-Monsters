using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    bool isStarted;

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (!isStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isStarted = true;
                Time.timeScale = 1;
            }
        }
    }
}
