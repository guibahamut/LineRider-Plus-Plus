using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    public Slider sliderVolume;



    [Header("Music")]
    public int currentMusicId = 0;
    public AudioClip[] musicList;

    void Start()
    { 
        audioSource.volume = PlayerPrefs.GetFloat("volume");
        if (sliderVolume != null)
        {
            sliderVolume.value = audioSource.volume;
        }

        PlayMusic(currentMusicId);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentMusicId++;

            if (currentMusicId >= musicList.Length) currentMusicId = 0;

            PlayMusic(currentMusicId);            
        }

        // Update music volume
        PlayerPrefs.SetFloat("volume", audioSource.volume);
    }

    void PlayMusic(int musicId)
    {
        audioSource.clip = musicList[musicId];
        audioSource.Play();
    }

    IEnumerator PlayMusic()
    {
        for (int i = 0; i < musicList.Length; i++)
        {
            audioSource.PlayOneShot(musicList[i]);
            while (audioSource.isPlaying)
                yield return i++;
        }
    }

}
