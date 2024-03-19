using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    private Player player;
    private FPSController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponentInParent<FPSController>();
        player = playerController.player;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickupItem();
        }
    }
    
    public void PickupItem()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position,transform.forward, out hit, 100f))
        {
            if (hit.collider.CompareTag("Pickup"))
            {
                player.Score += 5;
                Destroy(hit.collider.gameObject);
                Debug.Log("Hit Pickup");
            }
        }
        Debug.Log(player.Score);
    }
}
