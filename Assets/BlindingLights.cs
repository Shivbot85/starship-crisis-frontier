using UnityEngine;

public class BlindingLights : MonoBehaviour
{
    public Light lightSource;
    public Color flickerColor = Color.red;
    public Color stableColor = Color.white;
    public float minIntensity = 0.5f;
    public float maxIntensity = 1.5f;
    public float flickerSpeed = 0.1f;
    private bool componentsCombined = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!componentsCombined)
        {
            // Flicker light in red
            lightSource.color = flickerColor;
            lightSource.intensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PerlinNoise(Time.time * flickerSpeed, 0));
        }

    }
    public void OnComponentsCombined()
    {
        componentsCombined = true;
        lightSource.color = stableColor;
        lightSource.intensity = maxIntensity;  // Set to a stable intensity after combining
    }
}
