using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guesser_Script : MonoBehaviour {

    public int max;
    public int min;
    private int guess;
    public int count;


    // Use this for initialization
    private void Start () {

        print("Welcome to Number Guesser");
        print("Pick a number between " +min +" and " +max);

        //Is the value GUESS
        NextGuess();
        //Instructions - Push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter if correct");

        max = max + 1;
	}

    private void NextGuess() {
        count --;
        //random guess between max and min
		guess = Random.Range(min,max);
        print("Is the number " + guess + "?");
    }
	
	// Update is called once per frame
	public void Update () {
        //Up arrow
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
        //Down arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        //Enter
        else if (Input.GetKeyDown(KeyCode.Return)) {
            print("COMPUTER WIN!");
        }
        //If count gets to 0, you win 
        if (count == 0){
            print("I give in... you win");

        }
    }
}
