using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed = 100.0f;      // מהירות הסיבוב (מעלות לשנייה)

    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }
}
