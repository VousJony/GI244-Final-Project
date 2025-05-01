using System.Drawing;
using UnityEngine;

public class EndGameZone : MonoBehaviour
{
    private UIGameManager gameManager;
    public GameObject SummaryUI;
    public GameObject CloseJony;


    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game End");
            SummaryUI.SetActive(true);
            CloseJony.SetActive(false);
        }
    }
}
