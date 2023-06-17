using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    public float startTime = 60f;

    [SerializeField] TextMeshProUGUI CountdownText;

    void Start()
    {
        currentTime = startTime;
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            currentTime = startTime;
        }
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("f2");
        if (currentTime <= 0)
        {
            FindObjectOfType<OverallScript>().LoadLevel(0);
        }
    }
}