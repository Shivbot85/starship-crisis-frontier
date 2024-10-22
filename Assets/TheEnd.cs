using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    public ToggleComponents toggle;
    public GameObject quantumContainer;
    public TextMeshProUGUI textTimer;
    public countdown countdown;
    
    void OnTriggerEnter(Collider other)
    {
            toggle.ToggleLights(true);
            StopTimer();
            quantumContainer.GetComponent<Light>().enabled = true;
            SceneManager.LoadScene("End Scene - Won");
    
    }
    void StopTimer()
    {
        countdown.timerIsRunning = false;
        textTimer.color = Color.blue;
    }
}
