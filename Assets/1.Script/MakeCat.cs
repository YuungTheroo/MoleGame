using System.Xml.Serialization;
using UnityEngine;

public class MakeCat : MonoBehaviour
{
    public GameObject cat;
    public float startTime = 1.0f;
    public float repeatTime = 4.0f;
    public float xmin = -8.0f;
    public float xmax = 8.0f;
    public float zmin = -8.0f;
    public float zmax = 8.0f;


    void Start()
    {
        InvokeRepeating("makeCat", startTime, repeatTime);
    }


    void Update()
    {

    }

    void makeCat()
    {
        float xpos = Random.Range(xmin, xmax);
        float zpos = Random.Range(zmin, zmax);
        Vector3 pos = transform.position;
        pos.x = xpos;
        pos.z = zpos;
        Instantiate(cat, pos, cat.transform.rotation);
    }
}
