using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public Slider volumeSlider;

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadOptions()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void CloseGame()
    {
        //Debug.Log("QUIT!");
        Application.Quit();
    }

    public void CloseOptions()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
        AudioListener.volume = volumeSlider.value;
        //Debug.Log("Lautstaerke:" + volumeSlider.value);
    }
}
