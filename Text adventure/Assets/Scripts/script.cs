using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{

    public enum States { The_car,Play_dead,Back_yard01,Front_door,Wait01};
    public States currentState;
    public Text TextObject;
    public Text Titleobject;
    public int sleep;

    // Use this for initialization
    void Start()
    {
        currentState = States.The_car;
        sleep = Random.Range(1, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.The_car){The_car();}
        else if (currentState == States.Play_dead){Play_dead();}
        else if (currentState == States.Back_yard01) { Back_yard01(); }
        else if (currentState == States.Wait01) { Wait01();}
    }

    private void The_car()
    {
        Titleobject.text = "The Car";
        TextObject.text = "Your in the car arriving to your grandparents house. Your eyes are shut as the car is put in park.\n" +
            "You have 3 options... \n" +
            "1. you can either play dead and hope your parents leave you in the car. \n" +
            "2. Walk in the front door withe your parents. \n" +
            "3. sneak around back where the rest of the kids are playing.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Play_dead;}
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Front_door;}
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.Back_yard01;}
    }
    private void Play_dead()
    {
        Titleobject.text = "Attempt of Death";
        if (sleep <= 6)
        {
            TextObject.text = "Your parents try to wake you at first. but your awesome possum skills work out for the best. \n" +
            "about 15 minutes pass, Your getting the grumbles from your stomach. you can head through the back and sneak your way in. \n" +
            "1. wait longer pretending to fall asleep. \n" +
            "2. head through the back and sneak your way in.";
            if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Wait01;}
            if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Back_yard01;}
        }
        else
        {
            TextObject.text = "Your parents attempt to wake you but they poked your tickle spot as you give in a giggle. \n" +
            "mission failed... welll get em next time. \n" +
            "They ask you to help with the presents and food as you make your journey through the front door.\n" +
            "Press Enter to continue";
            if (Input.GetKeyDown(KeyCode.KeypadEnter)) { currentState = States.Front_door;}
        }
    }
    private void Front_Door()
    {
        Titleobject.text = "OH THE HUMANITY";
        TextObject.text = "";
    }
    private void Back_yard01()
    {
        Titleobject.text = "BackYard Hustle";
        TextObject.text = "You begin your journey to the back but As you turn the corner your pummeled in the face with a football, causing you too fall. as you get up a little ticked off. Your cousins ask for you to play a quick game of football... even before asking if you where okay.";
    }
    private void Wait01()
    {
        Titleobject.text = "The wait....";
        TextObject.text = "While waiting out you begin to get tired... you actually fall asleep. \n" +
        "You awake a bit later with a large food hunger.. you run inside with eyes only food ignoring all the commotion of you waking up finally.";
    }
}