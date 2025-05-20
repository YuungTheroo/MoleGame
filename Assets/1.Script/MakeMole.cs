using System.Xml.Serialization;
using UnityEngine;

public class MakeMole : MonoBehaviour
{
    public GameObject mole;
    public float startTime = 1.0f;
    public float repeatTime = 4.0f;
    public float xmin = -8.0f;
    public float xmax = 8.0f;
    public float zmin = -8.0f;
    public float zmax = 8.0f;


    void Start()
    {
        InvokeRepeating("makeMole", startTime, repeatTime);
    }


    void Update()
    {

    }

    void makeMole()
    {
        float xpos = Random.Range(xmin, xmax);
        float zpos = Random.Range(zmin, zmax);
        Vector3 pos = transform.position;
        pos.x = xpos;
        pos.z = zpos;
        Instantiate(mole, pos, mole.transform.rotation);
    }
}
