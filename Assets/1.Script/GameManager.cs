using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float axisSpeed = 15.0f;
    int score = 0;
    public TMP_Text textScore;
    public AudioClip clipDefeat;
    public AudioClip clipWin;
    public AudioClip clipHitMole;
    public AudioClip clipHitCat;
    public AudioClip clipStartVoice;
    public AudioSource audioSource;




    void Start()
    {
        updateScore();
        StartVoice();
    }


    void Update()
    {
        // escape 키 누르면 게임 종료
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EndScene");
    }

    public int getScore() { return score; }
    public void incScore() { score++; updateScore(); }
    public void decScore() { score--; updateScore(); }
    public void updateScore() { textScore.text = $"Score: {score}"; }

    public void HitMole()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipHitMole, 1.0f);
        audioSource.volume = prevVol;
    }
    public void HitCat()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipHitCat, 1.0f);
        audioSource.volume = prevVol;
    }
    public void Defeat()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipDefeat, 1.0f);
        audioSource.volume = prevVol;
    }
    public void Win()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipWin, 1.0f);
        audioSource.volume = prevVol;
    }
    public void StartVoice()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipStartVoice, 1.0f);
        audioSource.volume = prevVol;
    }
}
