using TMPro;
using System.Collections;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public countdown timerScript;  
    public AudioSource speech;  
    public TextMeshProUGUI storyText; 
    private int currentLine = 0;
    public float audioDelay = 5; 
    public string[] storyLines; 
    public float[] timestamps;  

    void Start()
    {
        speech.pitch = 0.95f;  
        storyText.color = Color.white;  
        StartCoroutine(StartSpeechWithDelay());  
    }

    IEnumerator StartSpeechWithDelay()
    {
        yield return new WaitForSeconds(5);
        speech.Play();  
        StartCoroutine(DisplayStory()); 
    }

    IEnumerator DisplayStory()
    {
        while (currentLine <= storyLines.Length)
        {
            yield return new WaitForSeconds(timestamps[currentLine]); 
            storyText.text = storyLines[currentLine]; 
            currentLine++;  
            if(currentLine >= storyLines.Length)
            {
                break;
            }
        }
        storyText.text = "";
        timerScript.StartTimer();
    }
}
