using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//////////////////////////////////////////////
//Assignment/Lab/Project: Collisions
//Name: Hunter Wright
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 3/25/2024
/////////////////////////////////////////////

public class GameController : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text menuMessage;
    [SerializeField] GameObject menuPanel;

    public Player player;
    private bool playerWin;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player = new Player();
        playerWin = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore()
    {
        player.Score += 5;
        UpdateUI();

        if (player.Score == 50)
        {
            playerWin = true;
            MenuOpen();
        }
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Trap"))
        {
            player.Health -= 10;
            Destroy(hit.gameObject);
            UpdateUI();

            if (player.Health == 0)
            {
                MenuOpen();
            }
        }
    }

    private void UpdateUI()
    {
        healthText.text = "Health: " + player.Health;
        scoreText.text = "Score: " + player.Score;
    }

    private void MenuOpen()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (playerWin)
        {
            menuMessage.text = "YOU WIN!!!";
        } else
        {
            menuMessage.text = "You died...";
        }
        menuPanel.SetActive(true);
        gameObject.GetComponent<FirstPersonController>().enabled = false;
    }

    public void OnReturnButtonHit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
