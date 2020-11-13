using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private Animator playerAnim;

    public CharacterController characterController;

    
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        
    }

    private void Move()
    {
        
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        playerAnim.SetBool("isWalking", vInput != 0 || hInput != 0);

        Vector3 move = transform.forward * vInput + transform.right * hInput;
        characterController.Move(speed * Time.deltaTime * move);
    }
}
