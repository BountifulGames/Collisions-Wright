using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text scoreText;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        Debug.Log(player.Health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore()
    {
        player.Score += 5;
        UpdateUI();
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Trap"))
        {
            player.Health -= 10;
            Destroy(hit.gameObject);
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        healthText.text = "Health: " + player.Health;
        scoreText.text = "Score: " + player.Score;
    }
}
