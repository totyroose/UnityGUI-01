using UnityEngine;
using UnityEngine.UI; // Required for using Slider
using TMPro; // Required for using TextMeshPro

public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI; // Reference to the Slider component
    private TextMeshProUGUI textSliderValue; // Reference to the TextMeshProUGUI component

    void Awake()
    {
        // Get reference to TextMeshProUGUI component on the same GameObject
        textSliderValue = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        // Show the initial slider value
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        // Update the text to show the current slider value
        string sliderMessage = sliderUI.value.ToString("00"); // Format value to 2 decimal places
        textSliderValue.text = sliderMessage;
    }
}
