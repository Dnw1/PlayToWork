using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour {

    [SerializeField] AudioSource Current;
    [SerializeField] private Sprite Play;
    [SerializeField] private Sprite Mute;
    [SerializeField] private Button ThisObject;
    private bool Off;

    void Start()
    {
        Current.Play();
    }


    public void control()
    {
        if (AudioListener.pause)
        {
            AudioListener.pause = false;
            ThisObject.image.overrideSprite = Play;
        }
        else if (AudioListener.pause == false)
        {
            AudioListener.pause = true;
            ThisObject.image.overrideSprite = Mute;
        }
    }
    private void CheckOn()
    {
        if (Current.isPlaying)
        {
            Current.Stop();
            ThisObject.image.overrideSprite = Mute;
            Off = true;
        }
    }
    private void CheckOff()
    {
        if (Off)
        {
            Current.Play();
            ThisObject.image.overrideSprite = Play;
            Off = false;
        }
    }
}
