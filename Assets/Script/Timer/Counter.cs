using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour {

    // Use this for initialization
    private float timeLeft = 13.0f;
    [SerializeField]private Image[] ImageHolder;
    [SerializeField]private Sprite[] SpriteHolder;

    public Image TimerImage;
    public string NextScene;

    void FixedUpdate()
    {
        Timecounter();
    }

    private void Timecounter()
    {
        timeLeft -= Time.deltaTime;
        //text.text = "Time Left:" + Mathf.Round(timeLeft);

        if (timeLeft < 11) { TimerImage.sprite = SpriteHolder[1]; }
        if (timeLeft < 10) { TimerImage.sprite = SpriteHolder[2]; }
        if (timeLeft < 9) { TimerImage.sprite = SpriteHolder[3]; }
        if (timeLeft < 8) { TimerImage.sprite = SpriteHolder[4]; }
        if (timeLeft < 7) { TimerImage.sprite = SpriteHolder[5]; }
        if (timeLeft < 6) { TimerImage.sprite = SpriteHolder[6]; }
        if (timeLeft < 5) { TimerImage.sprite = SpriteHolder[7]; }
        if (timeLeft < 4) { TimerImage.sprite = SpriteHolder[8]; }
        if (timeLeft < 3) { TimerImage.sprite = SpriteHolder[9]; }
        if (timeLeft < 2) { TimerImage.sprite = SpriteHolder[10]; }
        if (timeLeft < 1) { TimerImage.sprite = SpriteHolder[11]; }
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}
