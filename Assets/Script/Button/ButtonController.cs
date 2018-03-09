using UnityEngine;
using UnityEngine.SceneManagement;
//using TMPro;

public class ButtonController : MonoBehaviour
{

    [SerializeField] private string Load; // Houdt vast welke scene je laadt.
    public string Answer1; public string Answer2; public string Answer3; public string Answer4; //De text die toegevoegd wordt.
    [SerializeField]private GameObject ScoreHold; // Zit het ScoreHold object in.



    public void Q1()
    {
        SceneManager.LoadScene(Load); // Laad de volgende scene
        ScoreHold.GetComponent<Score>().AddInitiatief(); //Voegt een punt bij Score script Initiatief.
    }

    public void Q2()
    {
        SceneManager.LoadScene(Load); // Laad de volgende scene
        ScoreHold.GetComponent<Score>().AddTeamwork(); //Voegt een punt bij Score script Teamwork.
    }

    public void Q3()
    {
        SceneManager.LoadScene(Load); // Laad de volgende scene
        ScoreHold.GetComponent<Score>().AddAanpassen(); //Voegt een punt bij Score script Aanpassen.
    }

    public void Q4()
    {
        SceneManager.LoadScene(Load); // Laad de volgende scene
        ScoreHold.GetComponent<Score>().AddZelfstandigheid(); //Voegt een punt bij Score script Zelfstandigheid.
    }
}
