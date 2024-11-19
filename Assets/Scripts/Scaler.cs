using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float range = 2.0f;  // Amplitude of the pulsating effect
    [SerializeField] private float speed = 2.0f;      // Speed of the pulse

    void Update()
    {
        // The sin function returns value between 0 to 1 duo to absolute value
        float normalizedScale = Mathf.Abs(Mathf.Sin(Time.time * speed));

        // Calculate the scale
        float scaleFactor = normalizedScale * range;

        // Apply the scale
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }
}
