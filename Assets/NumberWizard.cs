﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    //Global scope for var in this instance
    int max ;
    int min ;
    int guess;

    int maxGuessesAllowed = 10;

    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
	}

   
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }



    void StartGame()
    {

        max = 1000;
        min = 1;
        NextGuess();

        max = max + 1;
    }

    void NextGuess()
    {
        int rand = Random.Range(min, max + 1);
        guess = (max + min) / rand;
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
