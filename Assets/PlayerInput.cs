using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]
    private float speed;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = 5f;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0f, y).normalized;

        if(move.magnitude >= 0.1f)
        {
            controller.Move(move * speed * Time.deltaTime);
        }


        
    }
}
