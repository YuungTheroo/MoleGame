using UnityEngine;

public class MoveAxisX : MonoBehaviour
{
    public float xmin = -10.0f;
    public float xmax = 10.0f;
    float speed = 0.0f;


    void Start()
    {
        
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        speed = gameManager.axisSpeed;
    }


    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float xpos = transform.position.x + xoff;
        if (xpos >= xmin && xpos <= xmax)
            transform.Translate(xoff, 0.0f, 0.0f);
    }
}
