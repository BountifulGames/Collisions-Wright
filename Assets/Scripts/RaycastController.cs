using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//////////////////////////////////////////////
//Assignment/Lab/Project: Collisions
//Name: Hunter Wright
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 3/25/2024
/////////////////////////////////////////////

public class RaycastController : MonoBehaviour
{
    [SerializeField] private GameObject playerObject;
    private Player player;
    private GameController playerController;

    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        playerController = playerObject.GetComponent<GameController>();
        player = playerController.player;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickupItem();
        }

        if (Input.GetMouseButtonDown(0))
        {
            DestroyTrap();
        }
    }
    
    public void PickupItem()
    {
        
        if (Physics.Raycast(transform.position,transform.forward, out hit, 2f))
        {
            if (hit.collider.CompareTag("Pickup"))
            {
                playerController.IncreaseScore();
                Destroy(hit.collider.gameObject);
                Debug.Log("Hit Pickup");
            }
        }
        //Debug.Log(player.Score);
    }

    public void DestroyTrap()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
        {
            if (hit.collider.CompareTag("Trap"))
            {
                Destroy(hit.collider.gameObject);
                Debug.Log("Destroy Trap");
            }
        }
    }
}
