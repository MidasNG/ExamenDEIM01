using System.Collections.Generic;
using UnityEngine;

public class RingRandomizer : MonoBehaviour
{
    public List<GameObject> children;
    public float xMax, yMax, yMin, zMax;

    void Start()
    {
        //Rellenar la lista
        while (transform.childCount > children.Count)
        {
            children.Add(transform.GetChild(children.Count).gameObject);
        }
    }

    void Update()
    {
        //Posición y rotación aleatorias
        if (Input.GetAxis("Randomize") > 0)
        {
            for (int i = 0; i < children.Count; i++)
            {
                children[i].transform.position = new Vector3(Random.Range(-xMax, xMax), Random.Range(yMin, yMax), Random.Range(-zMax, zMax));
                children[i].transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            }
        }
    }
}
