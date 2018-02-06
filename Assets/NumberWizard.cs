using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    //Global scope for var in this instance
    int max ;
    int min ;
    int guess;

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
        guess = 500;

        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal.");
    }
}
