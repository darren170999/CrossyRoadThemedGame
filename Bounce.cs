using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    [SerializeField] new private AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            audio.Play();
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            audio.Play();

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            audio.Play();
        }

    }
}