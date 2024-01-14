using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class Wasted : MonoBehaviour
{
    public TextMeshProUGUI wastedText; // Reference to the TextMeshProUGUI component for displaying "wasted"
    private bool isWasted = false; // Flag to track if "wasted" is displayed

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the TextMeshProUGUI reference
        wastedText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the object's Y-coordinate is below -2
        if (transform.position.y < -2f && !isWasted)
        {
            // Object is below Y -2, show "wasted" text and destroy the object
            ShowWastedTextAndDestroy();
        }
    }

    // Function to display "wasted" text and destroy the object
    void ShowWastedTextAndDestroy()
    {
        isWasted = true; // Set the flag to true
        wastedText.text = "ehheeh ololololo"; // Display "wasted" text
        Destroy(gameObject); // Destroy the game object this script is attached to
    }
}
