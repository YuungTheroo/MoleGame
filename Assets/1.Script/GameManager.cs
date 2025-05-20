using UnityEngine;
using TMPro; 
public class GameManager : MonoBehaviour
{
    
    public float axisSpeed = 15.0f;
    int score = 0;
    public TMP_Text textScore;


    void Start()
    {
        updateScore();
    }


    void Update()
    {

    }

    public int getScore() { return score; }
    public void incScore() { score++; updateScore(); }
    public void decScore() { score--; updateScore(); }

    public void updateScore() { textScore.text = $"Score: {score}"; }
}
