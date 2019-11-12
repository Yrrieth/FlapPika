﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public static int highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        GetComponent<UnityEngine.UI.Text>().text = "Highscore : " + highscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score > highscore)
        {
            highscore = Score.score;
            PlayerPrefs.SetInt("highscore", highscore);
            GetComponent<UnityEngine.UI.Text>().text = "Highscore : " + highscore.ToString();
        }
    }
}
