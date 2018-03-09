using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Scenario1"); // Laadt de eerste Scenario.
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
