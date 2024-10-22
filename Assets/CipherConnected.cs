using TMPro;
using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class CipherConnected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject A, B;
    public Material glowingMaterial;
    public GameObject cipher;
    TheEnd end;
    void GlowObjects()
    {
        A.GetComponent<Renderer>().material = glowingMaterial;
        B.GetComponent<Renderer>().material = glowingMaterial;

    }

}