using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpsound : MonoBehaviour
{
    public AudioSource jumpSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jumpSound.Play();
        }
    }
}
