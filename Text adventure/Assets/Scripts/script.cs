using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{

    public enum States { The_car,Play_dead,Back_yard01,Front_door,Wait01,Pass,Football_game01,Game_End01,Food01,Grandpa01,Old01,Young01,Downstairs01,Food02,Fridge,Fridge01,Bathroom01,clue };
    public States currentState;
    public Text TextObject;
    public Text TitleObject;
    public int sleep;
    public bool Game01;
    public bool Full01;
    public bool Gpa01;
    public bool Bcake;
    public bool sleep01;


    // Use this for initialization
    void Start()
    {
        currentState = States.The_car;
        sleep = Random.Range(1, 11);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.The_car) { The_car(); }
        else if (currentState == States.Play_dead) { Play_dead(); }
        else if (currentState == States.Back_yard01) { Back_yard01(); }
        else if (currentState == States.Wait01) { Wait01(); }
        else if (currentState == States.Front_door) { Front_Door(); }
        else if (currentState == States.Pass) { Pass(); }
        else if (currentState == States.Football_game01) { Football_game01(); }
        else if (currentState == States.Food01) { Food01(); }
        else if (currentState == States.Grandpa01) { Grandpa01(); }
        else if (currentState == States.Downstairs01) { Downstairs01(); }
        else if (currentState == States.Young01) { Young01(); }
        else if (currentState == States.Old01) { Old01(); }
        else if (currentState == States.Food02) { Food02();  }
        else if (currentState == States.Fridge) { Fridge(); }
        else if (currentState == States.Game_End01) { End_game01(); }
        else if (currentState == States.Fridge01) { Fridge01(); }
        else if (currentState == States.Bathroom01) { Bathroom01(); }
        else if (currentState == States.clue) { clue(); }
    }

    private void The_car()
    {
        TitleObject.text = "The Car";
        TextObject.text = "You're in the car arriving at your grandparent's house. Your eyes are shut as the car is put in park. \n" +
            "You have 3 options... \n" +
            "1. You can either play dead and hope your parents leave you in the car. \n" +
            "2. Walk in the front door with your parents. \n" +
            "3. Sneak around back where the rest of the kids are playing.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Play_dead;}
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Front_door;}
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.Back_yard01;}
    }
    private void Play_dead()
    {
        TitleObject.text = "Attempt of Death";
        if (sleep <= 6)
        {
            TextObject.text = "Your parents try to wake you at first. but your awesome possum skills work out for the best. \n" +
            "About 15 minutes pass, You're getting the grumbles from your stomach. you can head to the back and sneak your way in. \n" +
            "1. Wait longer pretending to fall asleep. \n" +
            "2. head to the back and sneak your way in.";
            if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Wait01;}
            if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Back_yard01;}
        }
        else
        {
            TextObject.text = "Your parents attempt to wake you but they poked your tickle spot as you give in a giggle. \n" +
            "mission failed... well get em next time. \n" +
            "They ask you to help with the presents and food as you make your journey through the front door.\n" +
            "Press Enter to continue";
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Front_door;}
        }
    }
    private void Front_Door()
    {
        TitleObject.text = "OH THE HUMANITY";
        TextObject.text = "Your parents assure you're awake, as you stumble out of the car and your parents make you carry out the birthday presents and let alone make you walk in first getting mauled by the dog and hearing your name called in excitement 50 times." +
        "The food is out and ready to eat as the bigger cousins are playing football outside. \n" +
        "1. Do you join them for a quick game? \n" +
        "2. Food is more important.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Football_game01; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Food01; }
    }
    private void Back_yard01()
    {
        TitleObject.text = "Backyard Hustle";
        TextObject.text = "You begin your journey to the back but As you turn the corner you pummeled in the face with a football, causing you to fall. \n" +
        "as you get up, Your cousins ask for you to play a quick game of football... even before asking if you were okay. \n" +
        "1. Take a hard pass. \n" +
        "2. Play a game.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Pass; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Football_game01; }
    }
    private void Wait01()
    {
        TitleObject.text = "The wait....";
        TextObject.text = "While waiting out you begin to get tired... you actually fall asleep. \n" +
        "You awake a bit later with a large food hunger.. you run inside with eyes only food ignoring all the commotion of you waking up finally. \n" +
        "Press enter to Continue.";
        sleep01 = true;
        if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Food02; }
    }
    private void Pass()
    {
        TitleObject.text = "Hard pass";
        TextObject.text = "By making some excuse that you're too hungry or weak to play you manage to get in through the back door and low and behold Food is already out and ready to eat. \n" +
            "Press Enter to continue";
        if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Food01; }
    }
    private void Food01()
    {
        TitleObject.text = "FOOD FINALLY";
        TextObject.text = "You begin devouring assorted meats and potatoes and for some reason still, have room for dessert. \n" +
        "But Oh no.. nature takes its course as you begin to have to pee due to a soda you drank before. \n" +
        "1. Pass Grandpa and use the upstairs. \n" +
        "2. Risk the dark realm of the downstairs.";
        Full01 = true;
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Grandpa01;}
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Downstairs01;}
        
    }
    private void Football_game01()
    {
        TitleObject.text = "Let the game begin";
        TextObject.text = "Let's see what damage you can try and cause back to your older cousins... (why did he say yes) \n" +
        "Your put on the losing team of course. \n" +
        "1.Choose the Left side with the young. \n" +
        "2.choose the Right side with the old.";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Young01; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Old01; }
    }
    private void Young01()
    {
        TitleObject.text = "VICTORY";
        TextObject.text = "You smile at the puny 5-year-old trembling before you as the game starts grabbing him and throwing him like the tiny toddler he is. causing the quarterback (your 10-year-old cousin) to flee backward as you trample him and winning the game due to him making a goal on himself.  the older cousins talk and point out that you made poor Timmy cry. as ashamed you are you are still glad to finally win a game for your helpless cousin's team you always set up with." +
        "After being ranted by you cousins for not being a man about things you walk inside for some finally well-deserved grub. \n" +
        "Press Enter to continue.";
        Game01 = false;
        if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Food02; }

    }
    private void Food02()
    {
        TitleObject.text = "THE STARVING GAME";
        TextObject.text = "There are few scraps left of actual food but plenty of deserts. you eat as much as you can but your hunger still is not fed. \n" +
        "You begin to have to pee due to a drink you had earlier. \n" +
        "1. Do you pass grandpa and use the upstairs. \n" +
        "2. risk the possibility of running into worse and venture in the dark parts of the downstairs.";
        Full01 = false;
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Grandpa01; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Downstairs01; }
    }
    private void Old01()
    {
        TitleObject.text = "Oh dear....";
        TextObject.text = "You stare deeply in your 26-year-old cousin's eyes as he gives a smirk... you gulp as you hear the words HIKE you find yourself fly in the air with the force of a train applied to your chest. as you lie on the ground in pain. your cousins give you good rep and help you up for taking a beating and loosing in the most honorable way. " +
        "while being patted on the back your hunger is getting larger with each pat.you walk inside as you see there's not as much food but your cousins offer you some of their food due to your injuries they made. \n " +
        "Press enter to continue";
        Game01 = true;
        if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Food02; }
    }
    private void Grandpa01()
    {
        if (Game01 == true)
        {
            TitleObject.text = "Grandpa...";
            TextObject.text = "As soon as you begin to pass grandpa he grabs your arm and pulls you close. (oh shoot) ''Hey there kiddo'' you roll your eyes praying that-- you know when I was your age..." +
            "You suddenly fake a bloody nose and tell him that you played a rough game of football outside as you run to the bathroom... mission success. \n" +
            "Press Enter to continue";
            Gpa01 = false;
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Game_End01; }
        }
        if (Game01 == false)
        {
            TitleObject.text = "The attack of the elderly";
            TextObject.text = "As soon as you begin to pass grandpa he grabs your arm and pulls you close. (oh shoot) ''Hey there kiddo'' you roll your eyes praying that-- you know when I was your age... You have no way out... looks like your gonna have to lend your ear for eternity. \n" +
            "Press Enter to continue";
            Gpa01 = true;
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Game_End01; }
        }
        

    }
    private void Downstairs01()
    {
        TitleObject.text = "downstairs";
        TextObject.text = "You Venture the dark of the world below as you search for the lights on the wall." +
        "your heart races as it feels like the walls never seem to end.... \n" +
        "1. Do you continue downstairs? \n" +
        "2. Do you run cowardly upstairs?";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Fridge; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Grandpa01; }
    }
    private void Fridge()
    {
        if (Full01 == false)
        {
            TitleObject.text = "But wait... is that a fridge?";
            TextObject.text = "You finally find the lights as you see there is a fridge full of food next to the light switch. \n" +
            "1. See whats good? \n" +
            "2. Continue on your way";
            if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.Fridge01; }
            if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.Bathroom01; }

        }
        if (Full01 == true)
        {
            TitleObject.text = "But wait... theres more";
            TextObject.text = "You finally find the lights as you see there is a fridge full of food next to the light switch. \n" +
            "There is a fridge but your already too full...so you continue on your way to the bathroom. \n" +
            "Press Enter to continue";
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Bathroom01; }
        }
    }
    private void Bathroom01()
    {
        TitleObject.text = "Sweet Release";
        TextObject.text = "You finally use the Bathroom and Are ready to eat some of that delicious cake! \n" +
        "Press Enter to Continue.";
        if(Input.GetKeyDown(KeyCode.Return)) { currentState = States.Game_End01; }
    }
    private void Fridge01()
    {
        if (Full01 == false)
        {
            TitleObject.text = "OH... CRAP";
            TextObject.text = "You eat as much as in the fridge as you can realizing.... YOU ATE THE BIRTHDAY CAKE. how are you going to explain that to the family.... or do you have too......you pretend nothing happens as you continue to find the bathroom and finally using it to fulfill natures demands. then run upstairs as you pretend nothing happened. \n" +
                "press Enter to continue";
            Bcake = true;
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Game_End01; }
        }
        if (Full01 == true)
        {
            TitleObject.text = "The Labratory";
            TextObject.text = "There's a bunch of food including the birthday cake... but your full so you continue to the bathroom. \n" +
                "Press enter to continue.";
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.Game_End01; }
        }
    }
    private void End_game01()
    {
        if (Bcake == true)
        {
            TitleObject.text = "The Game begins.. again";
            TextObject.text = "As grandma goes downstairs to grab the cake.... she yells as she realized the cake has been eaten.... she comes upstairs to begin the game of clue.  \n" +
            "Press Enter to Determine your fate";
            if (Input.GetKeyDown(KeyCode.Return)) { currentState = States.clue; }
        }
        if (Gpa01 == true)
        {
            TitleObject.text = "GET OVER HERE";
            TextObject.text = "You come out of the bathroom as granda pulls you aside as everyone beings the feast on the cake. 'AS I WAS SAYING... ' he says irritatingly...should have taken another route... you miss the feast of the cake and go home with no delicious cake but with memories of grandpas time when he was a kid. \n" +
            "You lose.. no cake for you";
        }
        else if (Bcake == false)
        {
            
            TitleObject.text = "YOU WIN";
            TextObject.text = "The feast was great! YOU WIN you survived and got the delicious cake as you go home and eat grandmas cookies she also gave you for being 'such a good boy.' truly a day to be alive.";
        }

    }
    private void clue()
    {
        if (sleep01 == true)
        {
            TitleObject.text = "Smooth Criminal";
            TextObject.text = "when she gets to you she asked if you ate it due to you going downstairs. But you explain you just woke up and now just joining the party. \n" +
            "you smooth criminal you....You win!";
        }
        if (sleep01 == false)
        {
            TitleObject.text = "RED HANDED";
            TextObject.text = "You give in immediately explaining you not knowing and the family shames you and mom and dad of course grounds you.... looks like your going out with that cake AND your grounded.... what a shame...";
        }
        
    }
}