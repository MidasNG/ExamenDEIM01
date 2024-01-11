using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float ySpeed, zSpeed;
    void Update()
    {
        transform.Rotate(0, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }
}
