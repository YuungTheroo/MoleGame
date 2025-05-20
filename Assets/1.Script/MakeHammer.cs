using UnityEngine;

public class MakeHammer : MonoBehaviour
{
    public GameObject hammer;
    private GameObject axisX, axisZ;


    void Start()
    {
        axisX = GameObject.Find("AxisX");
        axisZ = GameObject.Find("AxisZ");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            makeHammer();
    }

    void makeHammer()
    {
        Vector3 pos = hammer.transform.position; 
        pos.x = axisX.transform.position.x;
        pos.z = axisZ.transform.position.z;
        Instantiate(hammer, pos, hammer.transform.rotation);
    }
}
