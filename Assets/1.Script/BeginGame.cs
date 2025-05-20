using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    
    void Start()
    {
        Invoke("beginGame", 5.0f); 
    }


    void Update()
    {

    }

    void beginGame()
    {
        SceneManager.LoadScene("MoleScene"); 
    }
}
