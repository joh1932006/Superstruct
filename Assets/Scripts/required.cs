using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class required : MonoBehaviour
{
    float currentTime = 0f;
    public float startTime = 60f;

    [SerializeField] TextMeshProUGUI requiredText;

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
        requiredText.text = "1";
    }
}
