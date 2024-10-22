using UnityEngine;

using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    
    public float timeRemaining = 60f;  // Set the initial time here (seconds)
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;  // Drag and drop your UI Text element in the Inspector
    // Delay before the audio starts
    
    void Start()
    {
        timeText.color = Color.red;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;  // Decrease time each frame
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;  // Timer ends
                SceneManager.LoadScene("everybodyDies");
            }
        }

    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;  // Optional: Adjust to show full seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void StartTimer()
    {
        timerIsRunning = true;
    }

   
}
