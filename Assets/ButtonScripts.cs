using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    public GameObject AudioPlayer;
    // Start is called before the first frame update
    public void playAudio()
    {
        AudioPlayer.SetActive(true);
    }
}
