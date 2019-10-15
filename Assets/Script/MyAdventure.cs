using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
   //Hier beginnen alle states
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
        leven,
        dood,
        eind,
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
    //Hier staat wat voor type de input is
    {
        switch (currentState)
        {
            case States.start:
                //Dit is wat er kan gebeuren in de start state
            {
                if (input == "start")
                {
                    StartIntro();
                }
                else
                {
                    ShowMainMenu();
                }
            }
                break;

            case States.intro:
                //Dit is wat er kan gebeuren in de intro state
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
                //Dit is wat er kan gebeuren in de verder state
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
                //Dit is wat er kan gebeuren in de links state
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
                //Dit is wat er kan gebeuren in de rechts state
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
                //Dit is wat er kan gebeuren in de eropaf state
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
                //Dit is wat er kan gebeuren in de ervanweg state
            {
                if (input == "onderzoeken")
                {
                    onderzoeken();
                }
                
                else if (input == "weg")
                {
                    weg();
                }
                else
                {
                    ervanweg();
                }
            }
                break;

            case States.onderzoeken:
                //Dit is wat er kan gebeuren in de onderzoeken state
            {
                if (input == "menu")
                {
                    ShowMainMenu();
                }
                else
                {
                    onderzoeken();
                }
            }
                break;
            case States.weg:
                //Dit is wat er kan gebeuren in de weg state
            {
                if (input == "leven")
                {
                    leven();
                }
                else if (input == "dood")
                {
                    dood();
                }
                else
                {
                    weg();
                }
            }
                break;
            
            case States.leven:
                //Dit is wat er kan gebeuren in de leven state
            {
                if (input == "menu")
                {
                    ShowMainMenu();
                }
                else
                {
                    leven();
                }
            } 
                break;

            case States.dood:
                //Dit is wat er kan gebeuren in de dood state
            {
                if (input == "verder")
                {
                    eind();
                }
                else
                {
                    dood();
                }
            }
                break;

            case States.eind:
                //Dit is wat er kan gebeuren in de eind state
            {
                if (input == "menu")
                {
                    ShowMainMenu();
                }
                else
                {
                    eind();
                }
            }
                break;
        }
    }
// bij de voids zie je wat er gezegt word als je de naam van de void aangeeft in een case
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("type 'START' om te beginnen...");
        currentState = States.start;
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je word wakker in een duistere plek");
        Terminal.WriteLine("met alleen een rugzak met een zaklamp");
        Terminal.WriteLine("en een halve liter fles water erin.");
        Terminal.WriteLine("je doet de zaklamp aan en je ziet muren om je heen. Je zit in een doolhof!");
        Terminal.WriteLine("type 'VERDER' om verder te gaan....");
        currentState = States.intro;
    }

    void verder()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent aan het lopen en het lijkt alsof je maar niet verder komt.");
        Terminal.WriteLine("Uiteindelijk kun je naar rechts of links.");
        Terminal.WriteLine("Typ 'RECHTS' of 'LINKS'");
        Terminal.WriteLine("om naar rechts of links te gaan...");
        currentState = States.verder;
    }

    void rechts()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat naar rechts en je blijf lopen.");
        Terminal.WriteLine("Na een tijdje lopen hoor je een hard geluid.");
        Terminal.WriteLine("Typ 'EROPAF' om eropaf te gaan...");
        Terminal.WriteLine("Typ 'ERVANWEG' om ervan weg te gaan...");
        currentState = States.rechts;
    }

    void links()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet een figuur in de verte.");
        Terminal.WriteLine("Het komt met een hoog tempo op je af. het is te snel en je kan er niet van ontsnappen.");
        Terminal.WriteLine("Het beest verslint je");
        Terminal.WriteLine("Typ 'MENU' om naar het menu te gaan...");
        currentState = States.links;
    }

    void eropaf()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat op het geluid af en je ziet een figuur op je afkomen.");
        Terminal.WriteLine("Je word bang en je probeert weg te rennen maar je bent te langzaam.");
        Terminal.WriteLine("Het beest krijgt je te pakken.");
        Terminal.WriteLine("Typ 'MENU' om naar start te gaan...");
        currentState = States.eropaf;
    }

    void ervanweg()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je weet nu zeker dat je niet alleen bent.");
        Terminal.WriteLine("Je loopt door en je komt in een grote, ronde kamer met in het midden allemaal botten en opgedroogd bloed.");
        Terminal.WriteLine("Je kan nu onderzoeken of je kan weg gaan.");
        Terminal.WriteLine("Typ 'ONDERZOEKEN' of 'WEG'...");
        currentState = States.ervanweg;
    }

    void onderzoeken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat onderzoeken en je ziet dat");
        Terminal.WriteLine("er ook menselijke schedels tussen zitten.");
        Terminal.WriteLine("Je raakt in paniek en je wilt weg.");
        Terminal.WriteLine("Je hoort een geluid en je probeerd weg");
        Terminal.WriteLine("te rennen maar het is te laat.");
        Terminal.WriteLine("Er komt een groot monster op je af en");
        Terminal.WriteLine("het verslint je.");
        Terminal.WriteLine("Typ 'MENU' om opnieuw te beginnen...");
        currentState = States.onderzoeken;
    }

    void weg()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent zo hard mogelijk weg.");
        Terminal.WriteLine("Achter je hoor je harde geluiden");
        Terminal.WriteLine("en je bent blij dat je weg bent");
        Terminal.WriteLine("gegaan. Je komt aan bij twee gangen");
        Terminal.WriteLine("met twee borden. op de ene staat leven");
        Terminal.WriteLine("en op de ander staat dood. Beslis welke");
        Terminal.WriteLine("kant je opgaat.");
        Terminal.WriteLine("Typ 'LEVEN' om daarheen te gaan...");
        Terminal.WriteLine("Typ 'DOOD' om daarheen te gaan...");
        currentState = States.weg;
    }

    void dood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je had gelijk en dood was de juiste");
        Terminal.WriteLine("keuze. je ziet de uitgang en je rent");
        Terminal.WriteLine("erop af. je doet de deur open, je");
        Terminal.WriteLine("ziet een fel licht en je valt flauw.");
        Terminal.WriteLine("Opeens word je wakker in je bed, maar");
        Terminal.WriteLine("het voelde zo echt.");
        Terminal.WriteLine("Typ 'VERDER' om verder te gaan...");
        currentState = States.dood;
    }

    void leven()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een val!!");
        Terminal.WriteLine("Het monster staat voor je en");
        Terminal.WriteLine("je probeerd terug te gaan,");
        Terminal.WriteLine("maar het is gesloten. je kan");
        Terminal.WriteLine("nergens heen en het beest");
        Terminal.WriteLine("verslint je.");
        Terminal.WriteLine("Typ 'MENU' om naar het menu te gaan...");
        currentState = States.leven;
    }

    void eind()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt het gehaald!!!");
        Terminal.WriteLine("Typ 'MENU' om opnieuw te beginnen...");
        currentState = States.eind;
    }

    void menu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("type 'START' om te beginnen...");
        currentState = States.start;
    }
}
