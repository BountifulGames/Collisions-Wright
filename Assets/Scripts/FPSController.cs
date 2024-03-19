using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    //[SerializeField] private Animator anim;

    private float speed = 5.0f;
    private float cameraSens = 2.0f;
    private float moveVert;
    private float moveHor;
    private float rotX;
    private float rotY;

    public Player player;

    //private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();
        //DoorOpen();

    }

    public void IncreaseScore()
    {
        player.Score += 5;
        Debug.Log(player.Score);
    }

    //public void DoorOpen()
    //{
    //    if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100f))
    //    {
    //        if (hit.collider.CompareTag("Door") && Input.GetKeyDown(KeyCode.E))
    //        {
    //            anim = hit.collider.GetComponent<Animator>();
    //            if (anim.GetBool("DoorOpen"))
    //            {
    //                anim.SetBool("DoorOpen", false);
    //                anim.Play("close");
    //            }
    //            else if (!anim.GetBool("DoorOpen"))
    //            {
    //                anim.SetBool("DoorOpen", true);
    //                anim.Play("open");
    //            }
    //        }
    //    }
    //}

    public void PlayerControl()
    {
        moveVert = Input.GetAxis("Vertical") * speed;
        moveHor = Input.GetAxis("Horizontal") * speed;

        while (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 2;
        }
        Vector3 move = new Vector3(moveHor, 0, moveVert);
        move = transform.rotation * move;
        transform.position += move * Time.deltaTime;

        rotX = Input.GetAxis("Mouse X") * cameraSens;
        rotY -= Input.GetAxis("Mouse Y") * cameraSens;
        rotY = Mathf.Clamp(rotY, -90f, 90f);

        transform.Rotate(0, rotX, 0);
        playerCamera.transform.localRotation = Quaternion.Euler(rotY, 0, 0);
    }
}
