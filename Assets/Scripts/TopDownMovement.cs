﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private Text text;

    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        text = GetComponentInChildren<Text>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
        movementController.OnJumpEvent += Jump;
        text.text = CharacterManager.name;
    }

    private void Update()
    {
        if(CharacterManager.name != text.text){
            text.text = CharacterManager.name;
        }
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
        MainCameraMove();
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void Jump(Vector2 obj)
    {
        
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }

    private void MainCameraMove()
    {
        Vector3 cameraPosition = new Vector3(transform.position.x, transform.position.y, -10f);
        Camera.main.transform.position = cameraPosition;
    }
}