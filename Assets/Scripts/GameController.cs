using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore()
    {
        player.Score += 5;
        Debug.Log(player.Score);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            player.Health -= 10;
            Debug.Log(player.Health);
            Destroy(other.gameObject);
        }
    }
}
