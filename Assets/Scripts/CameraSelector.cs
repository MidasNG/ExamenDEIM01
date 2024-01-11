using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSelector : MonoBehaviour
{
    [SerializeField] private Camera camThird, camFirst;
    void Start()
    {
        camThird.depth = 1;
        camFirst.depth = -1;
    }

    void Update()
    {
        if (Input.GetButtonDown("Swap"))
        {
            camFirst.depth *= -1;
            camThird.depth *= -1;
        }
    }

}