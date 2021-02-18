using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown ResolutionDropdown;

    public AudioMixer audioMixer;

    Resolution[] resolutions; //Array that stores resolutions available from the system


    private void Start() //On start of the game
    {
        int CurrentResolutionIndex = 0;
        resolutions = Screen.resolutions;

        ResolutionDropdown.ClearOptions(); //Clears the dropdown list

        List<string> options = new List<string>(); //Creates list to store the resolutions for the dropdown

        for (int i = 0; i < resolutions.Length; i++) //Gets resolutions
        {
            string Option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(Option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                CurrentResolutionIndex = i;
            }
        }

        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = CurrentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int ResolutionIndex)
    {
        Resolution resolution = resolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
