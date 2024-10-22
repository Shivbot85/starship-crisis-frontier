using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;

public class GlowOnSelect : MonoBehaviour
{
    public Material glowMaterial;  
    private Material originalMaterial;
    private Renderer objectRenderer;
    private XRGrabInteractable interactable;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
        interactable = GetComponent<XRGrabInteractable>();

        interactable.selectEntered.AddListener(OnSelectEntered);
        interactable.selectExited.AddListener(OnSelectExited);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        objectRenderer.material = glowMaterial;  // Switch to glow material on select
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        objectRenderer.material = originalMaterial;  // Switch back to original material
    }
}


