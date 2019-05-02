using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    // declare audio 

    public AudioSource buttonClick;

    public void soundPlay()
    {
        buttonClick.Play();

    }
}
