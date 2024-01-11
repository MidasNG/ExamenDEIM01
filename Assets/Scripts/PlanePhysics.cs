using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class PlanePhysics : MonoBehaviour
{
    public float force, pitchTorque, rollTorque, yawTorque;
    public Rigidbody rb;
    public Score Score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Respawn
        if (Input.GetAxis("Respawn") > 0) { transform.position = new Vector3(0, 40, -20); transform.rotation = Quaternion.Euler(0, 0, 0); rb.velocity = new Vector3(0, 0, 0); rb.angularVelocity = new Vector3(0, 0, 0);}
        if (Input.GetButtonDown("Exit")) Application.Quit();
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * force);
        rb.AddRelativeTorque(Input.GetAxis("Pitch") * pitchTorque, Input.GetAxis("Yaw") * yawTorque, -Input.GetAxis("Roll") * rollTorque);
        rb.maxLinearVelocity = 50;
        rb.maxAngularVelocity = 2;
        
    }

    private void OnTriggerExit(Collider other)
    {
        Score.ScoreUp();
    }

    private void OnCollisionExit(Collision collision)
    {
        Score.ScoreReset();
    }
    
}
