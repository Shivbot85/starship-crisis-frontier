using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ToggleComponents : MonoBehaviour
    {
    public GameObject[] Lights;
    public Color flickerColor = Color.red;
    public Color stableColor = Color.white;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        foreach (GameObject lightObj in Lights)
        {
            FlickeringLight flicker = lightObj.GetComponent<FlickeringLight>();
            Light pointLight = lightObj.GetComponent<Light>();
            if (pointLight != null )
            {
                pointLight.enabled = false; 
                pointLight.color = flickerColor;
            }
            if (flicker != null)
            {
                flicker.enabled = true;
            }
        }
    }
    public void ToggleLights(bool componentsConnected)
    {
        foreach (GameObject lightObj in Lights)
        {
            FlickeringLight flicker = lightObj.GetComponent<FlickeringLight>();
            Light pointLight = lightObj.GetComponent<Light>();
            if (pointLight != null)
            {
                pointLight.enabled = true;
                pointLight.color = stableColor;
            }
            if (flicker != null)
            {
                flicker.enabled = false;
           
            }
        }
    }
}
