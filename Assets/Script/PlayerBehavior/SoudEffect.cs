using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudEffect : MonoBehaviour
{
    public AudioSource gunShotSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gunShotSound.Play();
        }
    }
}
