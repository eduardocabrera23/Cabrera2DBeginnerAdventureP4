using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   
    public InputAction MoveAction;
        
Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();

        Vector2 move;
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;

        transform.position = position;
    }
}
