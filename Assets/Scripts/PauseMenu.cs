using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseOverlay;
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public Slider volumeSlider;

    public void ContinueGame()
    {
        PauseOverlay.SetActive(false);
    }

    public void LoadOptions()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CloseOptions()
    {
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
        AudioListener.volume = volumeSlider.value;
        //Debug.Log("Lautstaerke:" + volumeSlider.value);
    }
}
