using UnityEngine;

public class KillHammer : MonoBehaviour
{
    public float killTime = 10.0f;

    void Start()
    {
        Destroy(gameObject, killTime);
    }


    void Update()
    {

    }
}
