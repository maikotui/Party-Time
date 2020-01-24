using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    /// Public variables
    [Header("References")]
    public string test;
    [Header("Settings")]
    public float killHeight;
    [Header("Movement")]
    public int speed;
    [Header("Sound")]
    public AudioClip sfx;

    /// Components
    CharacterController c_controller;

    /// Member variables
    bool m_isGrounded, m_wasGrounded = false;

    public void Start()
    {
        c_controller = GetComponent<CharacterController>();

        c_controller.enableOverlapRecovery = true;
    }

    public void Update()
    {
        if (transform.position.y >= killHeight)
        {
            // TODO: kill player
        }

        m_wasGrounded = m_isGrounded;

        GroundCheck();

    }

    private void GroundCheck()
    {

    }
}
