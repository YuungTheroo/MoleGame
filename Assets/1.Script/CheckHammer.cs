using UnityEngine;

public class CheckHammer : MonoBehaviour
{
    GameManager gameManager;


    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }


    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {


        string tag = collision.gameObject.tag;
        Debug.Log($"tag = {tag}");
        if (tag == "Mole")
        {
            gameManager.incScore();
            Destroy(gameObject, 0.25f);
            Destroy(collision.gameObject, 0.5f);
            gameManager.HitMole();
            Debug.Log($"score = {gameManager.getScore()}");
        }
        else if (tag == "Plane")
        {
            gameManager.decScore();
            Destroy(gameObject, 0.25f);
            Debug.Log($"score = {gameManager.getScore()}");
        }
        else if (tag == "Cat")
        {
            gameManager.decScore();
            Destroy(gameObject, 0.25f);
            Destroy(collision.gameObject, 0.5f);
            gameManager.HitCat();
            Debug.Log($"score = {gameManager.getScore()}");
        }
    }
}
