using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform door;
    public Vector3 openPosition;
    public float doorSpeed = 2.0f;

    private Vector3 initialPosition;
    private bool isOpening = false; 
    void Start()
    {
        initialPosition = door.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpening = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpening = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpening)
        {
            // Smoothly move the door to the open position
            door.position = Vector3.Lerp(door.position, openPosition, Time.deltaTime * doorSpeed);
        }
        else
        {
            // Smoothly move the door back to its initial position
            door.position = Vector3.Lerp(door.position, initialPosition, Time.deltaTime * doorSpeed);
        }
    }
}
