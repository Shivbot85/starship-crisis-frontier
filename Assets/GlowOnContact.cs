using TMPro;
using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class GlowOnContact : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject A, B, C;
    public Material glowingMaterial;
    private bool isAConnected = false;
    private bool isCConnected = false;
    public Transform objectToSlide;
    public float slideSpeed = 2f;
    private Vector3 startPosition;
    private Vector3 targetPosition;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == A)
        {

            isAConnected = true;

        }
        if (other.gameObject == C)
        {
            isCConnected = true;

        }


        if (isAConnected & isCConnected)
        {
            GlowObjects();
            createCipher();
            StartSliding();

        }
    }
    void GlowObjects()
    {
        A.GetComponent<Renderer>().material = glowingMaterial;
        B.GetComponent<Renderer>().material = glowingMaterial;
    }
    void createCipher()
    {
        GameObject combinedObject = new GameObject("Cipher");
        A.transform.SetParent(combinedObject.transform);
        B.transform.SetParent(combinedObject.transform);
        C.transform.SetParent(combinedObject.transform);
        A.GetComponent<Rigidbody>().isKinematic = true;
        C.GetComponent<Rigidbody>().isKinematic = true;

    }

    void StartSliding()
    {
        StartCoroutine(SlideUp());
    }

    IEnumerator SlideUp()
    {
        startPosition = new Vector3(objectToSlide.position.x, -2, objectToSlide.position.z);
        targetPosition = new Vector3(objectToSlide.position.x, 0, objectToSlide.position.z);
        objectToSlide.position = startPosition;
        while (Vector3.Distance(objectToSlide.position, targetPosition) > 0.01f)
        {
            objectToSlide.position = Vector3.Lerp(objectToSlide.position, targetPosition, slideSpeed * Time.deltaTime);
            yield return null;
        }

    }
}
