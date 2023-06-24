using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource[] audioSource;
    bool clicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySFX()
    {
        if (!clicked)
        {
            audioSource[0].Play();
            Debug.Log("FK U");
        }

        if (clicked)
        {
            audioSource[1].Play();
            Debug.Log("HELP");
        }
    }

    public void SwapSounds()
    {
        if (!clicked)
        {
            clicked = true;
        }
        else
        {
            clicked = false;
        }
    }
}
