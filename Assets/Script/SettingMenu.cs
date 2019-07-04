using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetBackgroundVolume (float volume)
    {
        audioMixer.SetFloat("background", volume);
        Debug.Log(volume);
    }

    public void SetEffectVolume(float volume)
    {
        audioMixer.SetFloat("effect", volume);
        Debug.Log(volume);
    }
}
