using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    public Rigidbody2D RB;

    [Header("Movement")]
    [SerializeField] float MoveSpeed;
    [SerializeField] float JumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 HorizontalInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        Vector3 HorizontalMovement = HorizontalInput * MoveSpeed * Time.deltaTime;
        transform.position += HorizontalMovement;
    }
}
