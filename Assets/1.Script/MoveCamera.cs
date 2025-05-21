using Unity.Mathematics;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    int cameraNum = 1;
    int cFixed = 1;
    bool prevClick = false;
    public GameObject plane;
    public float rotSpeed = 500.0f;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cameraNum = 1;
            cFixed = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            cameraNum = 2;

        if (cameraNum == 1)
            Camera1();
        if (cameraNum == 2)
            Camera2();
    }

    void Camera1()
    {
        if (cFixed == 0)
        {
            transform.position = new Vector3(0.0f, 4.42f, -16.35f);
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            cFixed = 1;
        }
        Eyeable();
        MoveCamera1();
    }
    void Camera2()
    {
        transform.position = new Vector3(0.0f, 20.0f, 0.0f);
        transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
        Invisible();
    }
    void Invisible()
    {
        GameObject AxisX = GameObject.Find("AxisX");
        AxisX.GetComponent<Renderer>().enabled = false;
        GameObject AxisZ = GameObject.Find("AxisZ");
        AxisZ.GetComponent<Renderer>().enabled = false;
    }
    void Eyeable()
    {
        GameObject AxisX = GameObject.Find("AxisX");
        AxisX.GetComponent<Renderer>().enabled = true;
        GameObject AxisZ = GameObject.Find("AxisZ");
        AxisZ.GetComponent<Renderer>().enabled = true;
    }
    void MoveCamera1()
    {
        if (prevClick && Input.GetAxis("Fire1") != 0.0f)
        {
            float angOff = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
            transform.RotateAround(plane.transform.position, Vector3.up, angOff);
        }
        prevClick = (Input.GetAxis("Fire1") == 0.0f) ? false : true;


    }

}
