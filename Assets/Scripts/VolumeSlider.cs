using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        float dB = volume > 0.0001f
            ? Mathf.Log10(volume) * 20f
            : -80f;

        audioMixer.SetFloat("MasterVolume", dB);
    }
}