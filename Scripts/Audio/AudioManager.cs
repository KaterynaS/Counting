using UnityEngine;
using System;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public Sound[] yesSounds;
    public Sound[] noSounds;


    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        foreach (Sound s in yesSounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        foreach (Sound s in noSounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }


    }

    void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound spelled incorrectly");
            return;
        }
            
        s.source.Play();
    }

    public void PlayYes()
    {

        //choose sound from yesArray

        int e = UnityEngine.Random.Range(0, yesSounds.Length);
        Debug.Log("AudioManager, PlayYes, sound s number: " + e);
        Sound s = yesSounds[e];
        Debug.Log("AudioManager, PlayYes, sound s name " + s.name);

        s.source.Play();
    }

    public void PlayNo()
    {

        int e = UnityEngine.Random.Range(0, noSounds.Length);
        Debug.Log("AudioManager, PlayNo, sound s number: " + e);
        Sound s = noSounds[e];
        Debug.Log("AudioManager, PlayNo, sound s name: " + s.name);

        s.source.Play();
    }
}
