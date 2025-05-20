using UnityEngine;

public class MoveMole : MonoBehaviour
{
    public float ymin = -2.0f;
    public float ymax = 0.0f;
    public float speed = 1.0f;
    public float ypos = 0.0f;


    void Start()
    {
        ypos = ymin;
    }

    void Update()
    {
        ypos += speed * Time.deltaTime;
        if (ypos > ymax)
        {
            speed = -speed;
        }
        else if (ypos < ymin)
        {
            Destroy(gameObject);
        }
        Vector3 pos = transform.position;
        pos.y = ypos;
        transform.position = pos;
    }
}
