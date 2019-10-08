using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start, 
        intro,
        verder,
        rechts,
        links,
        eropaf,
        ervanweg,
        onderzoeken,
        weg,
    }


    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.start:
            {
                if (input == "start")
                {
                    StartIntro();
                }
                else if (input == "1337")
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("leet!");
                }
                else
                {
                    ShowMainMenu();
                }
            }
                break;

            case States.intro:
            {
                if (input == "verder")
                {
                    verder();
                }
                else
                {
                    StartIntro();
                }
            }
                break;

            case States.verder:
            {
                if (input == "rechts")
                {
                    rechts();
                }
                else if (input == "links")
                {
                    links();
                }
                else
                {
                    verder();
                }
            }
                break;
            
            case States.links:
            {
                if (input == "menu")
                {
                    menu();
                }
                else
                {
                    links();
                }
            }
                break;
            
            case States.rechts:
            {
                if (input == "eropaf")
                {
                    eropaf();
                }
                else if (input == "ervanweg")
                {
                    ervanweg();
                }
                else
                {
                    rechts();
                }
            }
                break;

            case States.eropaf:
            {
                if (input == "menu")
                {
                    menu();
                }
                else
                {
                    eropaf();
                }
            }
                break;

            case States.ervanweg:
            {
                if (input == "onderzoeken")
                {
                    
                }
            }
                break;
        }
    }
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("type 'start' om te beginnen...");
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je word wakker in een duistere plek");
        Terminal.WriteLine("met alleen een rugzak met een zaklamp");
        Terminal.WriteLine("en een halve liter fles water erin.");
        Terminal.WriteLine("je doet de zaklamp aan en je ziet muren om je heen. Je zit in een doolhof!");
        Terminal.WriteLine("type verder om verder te gaan....");
        currentState = States.intro;
    }

    void verder()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent aan het lopen en het lijkt alsof je maar niet verder komt.");
        Terminal.WriteLine("Uiteindelijk kun je naar rechts of links.");
        Terminal.WriteLine("Typ RECHTS of LINKS om naar rechts of links te gaan...");
        currentState = States.verder;
    }

    void rechts()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat naar rechts en je blijf lopen.");
        Terminal.WriteLine("Na een tijdje lopen hoor je een hard geluid.");
        Terminal.WriteLine("Type EROPAF om eropaf te gaan of ERVANWEG om ervan weg te gaan... ");
        currentState = States.rechts;
    }

    void links()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet een figuur in de verte.");
        Terminal.WriteLine("Het komt met een hoog tempo op je af. het is te snel en je kan er niet van ontsnappen.");
        Terminal.WriteLine("Het beest verslint je");
        Terminal.WriteLine("Typ MENU om naar het menu te gaan...");
        currentState = States.links;
    }

    void eropaf()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat op het geluid af en je ziet een figuur op je afkomen.");
        Terminal.WriteLine("Je word bang en je probeert weg te rennen maar je bent te langzaam.");
        Terminal.WriteLine("Het beest krijgt je te pakken. Typ MENU om naar start te gaan...");
        currentState = States.eropaf;
    }

    void ervanweg()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je weet nu zeker dat je niet alleen bent.");
        Terminal.WriteLine("Je loopt door en je komt in een grote, ronde kamer met in het midden allemaal botten en opgedroogd bloed.");
        Terminal.WriteLine("Je kan nu onderzoeken of je kan weg gaan.");
        Terminal.WriteLine("Typ ONDERZOEKEN of WEG...");
        currentState = States.ervanweg;
    }

    void onderzoeken()
    {
        Terminal.ClearScreen();
    }

    void weg()
    {
        Terminal.ClearScreen();
    }

    void menu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("type 'start' om te beginnen...");
        currentState = States.start;
    }
}
