using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public enum States { cell, window, gate, bed };
    public States currentState;

    // Use this for initialization
    void Start()
    {
        currentState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.cell){Cell();}
        if (currentState == States.bed){Bed();}
        if (currentState == States.gate){Gate();}
    }

    private void Cell()
    {
        print("You are in a cell. It's gross and dark and stinky.\n" +
            "There is a window.\n" +
            "There is a Gate\n" +
            "There is a Bed\n" +
            "Press W for Window, G for Gate, B for Bed.\n");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Bed()
    {
        print("Your Looking at the dark gross bed./n" +
            "There is a window./n" +
            "There is a Gate./n" +
            "There is a Bed./n" +
            "Press W for Window, G for Gate, B for Bed./n");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Gate()
    {
        print("The Gate is barred and locked... no way your getting through this way./n" +
            "There is a window./n" +
            "There is a Gate./n" +
            "There is a Bed./n" +
            "Press W for Window, G for Gate, B for Bed./n");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
}