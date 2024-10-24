using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    // tạo biến lưu trữ audio source
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    // tạo biến lưu trữ audio clip
    public AudioClip musicClip; // nhạc nền
    public AudioClip bulletCLip;// âm thanh vũ khí
    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

    public void Playsfx(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);
    }    
    
}
