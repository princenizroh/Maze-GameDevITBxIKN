using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    // private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 10.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        // controller = gameObject.GetComponent<CharacterController>();
 
    }

    // Update is called once per frame
    void Update()
    {
        // groundedPlayer = controller.isGrounded;
        // if (groundedPlayer && playerVelocity.y <0)
        // {
        //     playerVelocity.y = 0;
        // }

        // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // controller.Move(move * Time.deltaTime * playerSpeed);

        // if (move != Vector3.zero)
        // {
        //     gameObject.transform.forward = move;
        // }

        playerVelocity.y += gravityValue * Time.deltaTime * playerSpeed;

    }
}
