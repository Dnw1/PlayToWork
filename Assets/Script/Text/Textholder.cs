using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textholder : MonoBehaviour {

    private string Initiatief;
    private string Teamwork;
    private string Aanpassen;
    private string Zelfstandigheid;

    public Text First;
    public Text Second;
    public Text Third;
    public Text Fourth;

    public int Count;

    void Start() { GetScenario(); }

    public void GetScenario()
    {
        switch (Count)
        {
            case 1:
                ScenarioOne();
                break;
            case 2:
                ScenarioTwo();
                break;
            case 3:
                ScenarioThree();
                break;
            case 4:
                ScenarioFour();
                break;
            case 5:
                ScenarioFive();
                break;
            case 6:
                ScenarioSix();
                break;
            case 7:
                ScenarioSeven();
                break;
            case 8:
                ScenarioEight();
                break;
        }
        First.GetComponent<Text>().text = Initiatief;
        Second.GetComponent<Text>().text = Teamwork;
        Third.GetComponent<Text>().text = Aanpassen;
        Fourth.GetComponent<Text>().text = Zelfstandigheid;
    }



    private void ScenarioOne()
    {
        //Klagende klant
        Initiatief = "Probeer zelf de klant zo snel mogelijk te helpen.";
        Teamwork = "Vraag een collega/leidinggevende voor hulp.";
        Aanpassen = "Blijf kalm en luister aandachtig.";
        Zelfstandigheid = "Werk zo hard als je kan om het zelf op te gaan lossen.";
    }
    private void ScenarioTwo()
    {
        //Stelende klant
        Initiatief = "Licht meteen de cassieres in.";
        Teamwork = "Vraag collega's om ook op hem/haar te letten.";
        Aanpassen = "Licht een leidinggevende in.";
        Zelfstandigheid = "Benader een klant.";
    }
    private void ScenarioThree()
    {
        //Discussie met collega/leidinggevende
        Initiatief = "Bespreek snel een compromis en werk verder.";
        Teamwork = "Vraag aan collega's hun mening.";
        Aanpassen = "Neem de tijd om de discussie te beeindigen.";
        Zelfstandigheid = "Doe het na het argument op jouw manier.";
    }
    private void ScenarioFour()
    {
        //Te weinig personeel
        Initiatief = "Stel voor om klanten te compenseren voor het ongemak.";
        Teamwork = "Spreek een plan af zodat alles zo soepel mogelijk loopt.";
        Aanpassen = "Help collega's en klanten die prioriteit hebben.";
        Zelfstandigheid = "Werk zo snel mogelijk en wees bereid overuren te maken.";
    }
    private void ScenarioFive()
    {
        //Klant vraagt naar iets wat je niet weet
        Initiatief = "Werk samen met de klant tot je op een antwoord komt.";
        Teamwork = "Benader een collega voor hulp.";
        Aanpassen = "Benader een collega voor hulp en blijf erbij om zelf ook te leren.";
        Zelfstandigheid = "Zeg de klant dat je het niet weet en verwijs ze naar een collega.";
    }
    private void ScenarioSix()
    {
        //Weinig te doen
        Initiatief = "Benader een leidinggevende en vraag wat je kan doen.";
        Teamwork = "Help je collega's die nog niet klaar zijn.";
        Aanpassen = "Neem de tijd om te kijken of je nog wat kan verbeteren aan je eigen werk.";
        Zelfstandigheid = "Ga zelf opzoek naar klusjes.";
    }
    private void ScenarioSeven()
    {
        //Collega wilt help maar je hebt het al druk
        Initiatief = "Help je collega zodra je kan.";
        Teamwork = "Spreek af dat zodra jullie klaar zijn met zijn werk, jullie samen verder gaan aan jouw werk.";
        Aanpassen = "je maakt eerst het belangrijkste van jouw werk af en helpt dan je collega.";
        Zelfstandigheid = "Je maakt eerst je eigen werk af en kijkt daarna waar je collega hulp bij nodig heeft.";
    }
    private void ScenarioEight()
    {
        //Klant veroorzaakt commotie en is lastig
        Initiatief = "Benader de klant en vraag hem te vertrekken.";
        Teamwork = "Licht een leidinggevende in en help zover je kan.";
        Aanpassen = "Benader de klant en probeer hem/haar te kalmeren.";
        Zelfstandigheid = "Licht een leidinggevende in en probeer verder te werken.";
    }
}
