using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private static int Initiatief; // Houdt initiatief punten bij.
    private static int Teamwork; // Houdt teamwork punten bij.
    private static int Aanpassen; // Houdt aanpassen punten bij.
    private static int Zelfstandigheid; // Houdt zelfstandigheid punten bij.

    [SerializeField] private Text ShowInitiatief;
    [SerializeField] private Text ShowTeamwork;
    [SerializeField] private Text ShowAanpassen;
    [SerializeField] private Text ShowZelfstandigheid;

    public bool IsAtStart;

    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        StartGame();
    }

    public void StartGame()
    {
        if (IsAtStart)
        {
            Initiatief = 0; Teamwork = 0; Aanpassen = 0; Zelfstandigheid = 0;
        }
    }

    public void AddInitiatief()
    {
        Initiatief = Initiatief + 1; // Voeg een punt bij Ini toe.
        Debug.Log(Initiatief);
    }
    public void AddTeamwork()
    {
        Teamwork = Teamwork + 1; // Voeg een punt bij Team toe.
    }
    public void AddAanpassen()
    {
        Aanpassen = Aanpassen + 1; // Voeg een punt bij Aan toe.
    }
    public void AddZelfstandigheid()
    {
        Zelfstandigheid = Zelfstandigheid + 1; // Voeg een punt bij Zelf toe.
    }

    public void ShowScore()
    {
        ShowInitiatief.text = Initiatief.ToString();
        ShowTeamwork.text = Teamwork.ToString();
        ShowAanpassen.text = Aanpassen.ToString();
        ShowZelfstandigheid.text = Zelfstandigheid.ToString();
    }
}
