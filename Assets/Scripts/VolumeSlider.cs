using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(SetVolume);
        SetVolume(slider.value);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat(
            "MasterVolume",
            Mathf.Log10(Mathf.Max(volume, 0.0001f)) * 20f
        );
    }
}