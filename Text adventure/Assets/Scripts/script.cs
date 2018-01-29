using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{

    public enum States { The_car,Play_dead,};
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
        if (currentState == States.Play_dead){Play_dead();}
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
    }
    private void Play_dead()
    {
        Titleobject.text = "Attempt of Death";
        if (sleep <= 6)
        {

        }
        else
        {
            TextObject.text = "";
        }
        
    }
}