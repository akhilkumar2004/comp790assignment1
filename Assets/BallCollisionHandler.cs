using UnityEngine;

public class BallCollisionHandler : MonoBehaviour
{
    public BallPrefab ballPrefab; // Note: ballPrefab should match the class/type in your project

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);

        // Check if the ball hit the target
        if (collision.gameObject.CompareTag("ball"))
        {

            Score.scoreValue += 1;

            
        }
    }
}

