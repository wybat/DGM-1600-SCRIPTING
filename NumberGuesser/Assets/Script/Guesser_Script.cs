﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guesser_Script : MonoBehaviour {

    public int max = 1000;
    public int min = 1;
    public int guess;



    // Use this for initialization
    private void Start () {

        print("Welcome to Number Guesser");
        print("Pick a number between " +min +" and " +max);

        //Is the value GUESS
        print("Is the number 500");
        //Instructions - Push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter if correct");

	}
	
	// Update is called once per frame
	public void Update () {
        
	}
}
