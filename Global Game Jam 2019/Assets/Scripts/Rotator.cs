using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    Gyroscope gyro;
    Vector3 initRot;

    // Start is called before the first frame update
    void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
        initRot = Input.acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
            Calibrate();
            
        Rotate(gyro.rotationRate);
    }

    public void Rotate(Vector3 rot)
    {
        transform.eulerAngles = initRot + new Vector3(-rot.x, -rot.y, rot.z);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        initRot = transform.eulerAngles;
    }

    public void Calibrate ()
    {
        initRot = Vector3.zero;
    }
}
