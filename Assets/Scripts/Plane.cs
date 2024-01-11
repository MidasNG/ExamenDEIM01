using UnityEngine;

public class Plane : MonoBehaviour
{
    public float speed, pitchSpeed, rollSpeed, yawSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Rotación
        transform.Rotate(Input.GetAxis("Pitch") * pitchSpeed * Time.deltaTime, Input.GetAxis("Yaw") * yawSpeed * Time.deltaTime, -Input.GetAxis("Roll") * rollSpeed * Time.deltaTime);
    }
}
