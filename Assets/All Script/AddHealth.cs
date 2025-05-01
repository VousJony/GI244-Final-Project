using UnityEngine;

public class AddHealth : MonoBehaviour
{
    private int DeHealth = 1;
    private UIGameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<UIGameManager>();
    }

    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            gameManager.DeleteScore(DeHealth);
            Destroy(gameObject);
            Debug.Log("Healing");


        }
    }
}
