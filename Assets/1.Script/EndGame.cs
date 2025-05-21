using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public AudioClip clipWin;
    public AudioSource audioSource;

    void Start()
    {
        Win();
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("MoleScene");
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
            Debug.Log("종료");
        }
    }
    public void Win()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipWin, 1.0f);
        audioSource.volume = prevVol;
    }

}
