
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    
    CharacterController playerController;
    Vector3 moveVector = Vector3.zero; 
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpSpeed; 
    [SerializeField] private float xPos = 8.8f;
    [SerializeField] private float gravity;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        ConstraintsPlayerMovement();
        PlayerPushed();
        
    }
    
    void playerMovement()
    {
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;

        playerJump();
        
        moveVector.y -= gravity * Time.deltaTime;
        playerController.Move(moveVector * Time.deltaTime);

        
    }
    void playerJump()
    {
        if (playerController.isGrounded && Input.GetButton("Jump"))
        {
            moveVector.y = jumpSpeed;
        }
    }
    //if the player position is < -xPos or >xPos it stops moving.
    void ConstraintsPlayerMovement()
    {
        if (playerController.transform.position.x < -xPos)
        {
            playerController.transform.position = new Vector3(-xPos, playerController.transform.position.y, 0);
            playerController.enabled = true;
        }
        if (playerController.transform.position.x > xPos)
        {
            playerController.transform.position = new Vector3(xPos, playerController.transform.position.y, 0);
            playerController.enabled = true;
        }
        
    }
    //if the player collides with a ladder collider he is allowed to go up
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ladder"))
        {
            moveVector.y = Input.GetAxis("Vertical") * moveSpeed;
        }
    }
    
    void PlayerPushed()
    {
        if(!playerController.enabled)
        {
            transform.Translate(Vector3.right * 4.5f*Time.deltaTime);
        }
    }    

}
