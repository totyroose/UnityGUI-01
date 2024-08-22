using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitalTimer : MonoBehaviour
{
	private TextMeshProUGUI timerText;
    private float _timer;

    void Awake()
    {
        // Get reference to TextMeshProUGUI component attached to this GameObject
        timerText = GetComponent<TextMeshProUGUI>();

        // Check if the TextMeshProUGUI component was found
        if (timerText == null)
        {
            Debug.LogError("TextMeshProUGUI component is missing from this GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timerText != null)
        {
            // Increment the timer by the time passed since the last frame
            _timer += Time.deltaTime;

            
            timerText.text = _timer.ToString("00");
           // timerText.text = _timer.ToString("F1");// add one dicimal place
        }
    }
}
