using UnityEngine;
using UnityEngine.UI; // Required for using Button

public class ButtonsManager : MonoBehaviour
{
    public Canvas canvasBG;
    public Canvas canvas1; // Reference to the first canvas
    public Canvas canvas2; // Reference to the second canvas
    public Canvas canvas3; // Reference to the third canvas

    public Button button1; // Reference to the first button
    public Button button2; // Reference to the second button
    public Button button3; // Reference to the third button
    public Button button4; // Reference to the third button

    void Start()
    {
        // Add listeners to buttons
        button1.onClick.AddListener(() => ShowCanvas(canvas1));
        button2.onClick.AddListener(() => ShowCanvas(canvas2));
        button3.onClick.AddListener(() => ShowCanvas(canvas3));
        button4.onClick.AddListener(() => ShowCanvas(canvasBG));

        // Ensure only the first canvas is active at the start
        ShowCanvas(canvasBG);
    }

    void ShowCanvas(Canvas canvasToShow)
    {
        // Deactivate all canvases
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(false);
        canvas3.gameObject.SetActive(false);

        // Activate the selected canvas
        canvasToShow.gameObject.SetActive(true);
    }
}

