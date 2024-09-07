using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0; // Static variable to track the score
    public TMP_Text score; // Private variable for the Text component

    void Start()
    {
        score = GetComponent<TMP_Text>();


        // Check if the Text component is found
        if (score == null)
        {
            Debug.LogError("Text component not found. Ensure there is a GameObject named 'Text (TMP)' with a Text component.");
        }
    }
    
    void Update()
    {    
        // Only update the text if the Text component is not null
        if (score != null)
        {
            score.text = "Score: " + scoreValue;
        }
}
}
