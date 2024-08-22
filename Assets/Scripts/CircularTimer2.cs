using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CircularTimer2 : MonoBehaviour
{
    private Image timerImage; // Reference to the Image component used for the progress bar
   
    public float countdownTime = 30f; // Total time for the countdown in seconds

    private float timeRemaining;
    private bool isCountingDown = false;

    private void Awake()
    {
        timerImage = GetComponent<Image>();
    }
    void Start()
    {
        // Initialize timer
        if (timerImage == null)
        {
            Debug.LogError("timer image is not assigned in the Inspector.");
            return; // Exit if the references are not set
        }

        timeRemaining = countdownTime;
        UpdateUI();
        StartCountdown();
    }

    void Update()
    {
        if (isCountingDown)
        {
            // Update the timer
            timeRemaining -= Time.deltaTime;

            // Check if the timer has finished
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isCountingDown = false;
            }

            // Update UI elements
            UpdateUI();
        }
    }

    void StartCountdown()
    {
        isCountingDown = true;
    }

    void UpdateUI()
    {
        if (timerImage == null)
        {
            Debug.LogError("Timer Image is not assigned in the Inspector.");
            return; // Exit if the references are not set
        }

        // Update the timer image
        float fillAmount = timeRemaining / countdownTime;
        timerImage.fillAmount = fillAmount;

    }
}
