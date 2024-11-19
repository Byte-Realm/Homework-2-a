using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private float range = 5.0f;
    [Tooltip("The range in which the object is going to move in between, for an example between 5 to -5 and vice versa")]
    [SerializeField] private float speed = 2.0f;
    [Tooltip("The speed in which the object will move, gradually decreasing when about to reach a boundary and increase when headed to then other")]

    void Update()
    {       
        // Calculate the X position using the sin function 
        // The sin function will return a value between 1 to -1
        // Multiplied by the speed to allow customization and Time.time for real time translation
        // Finally multiplied by the range to allow a customizable set for a boundary.
        float xPosition = Mathf.Sin(Time.time * speed) * range;

        // Update the object's position
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }
}
