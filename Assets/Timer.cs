using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int startTime = 5; // Starting time in seconds
    private float timeRemaining; // Time remaining
    public TMP_Text timerText; // Reference to the UI text component
    public GameObject target; // Reference to the target GameObject

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = startTime;
        UpdateTimerDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        // Reduce time remaining if greater than zero
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            // Time has run out
            DestroyTarget();
        }
    }

    void UpdateTimerDisplay()
    {
        // Update the timer text display
        timerText.text = "Timer: " + Mathf.Ceil(timeRemaining).ToString();
    }

    void DestroyTarget()
    {
        if (target != null)
        {
            Destroy(target);
            
        }
        // Optionally, destroy this Timer script component itself if you don't need it anymore
        // Destroy(this);
    }
}



