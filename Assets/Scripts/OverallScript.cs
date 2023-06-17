using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverallScript : MonoBehaviour
{
    public GameObject PauseOverlay;
    public int clickCount = 0;
    bool wasJustClicked = true;
    public int level;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PauseMenu();
    }

    public void LoadLevel(int index)
    {
        level = index;
        SceneManager.LoadScene(level);
    }

    void PauseMenu()
    {


        if (Input.GetKey(KeyCode.Escape))
        {
            if (wasJustClicked)
            {
                wasJustClicked = false;
                if (clickCount % 2 != 0)
                    PauseOverlay.SetActive(false);
                if (clickCount % 2 == 0)
                    PauseOverlay.SetActive(true);

                clickCount++;
            }
        }
        else
            wasJustClicked = true;
    }
    public void ResetClickCount()
    {
        clickCount = 0;
    }
}
