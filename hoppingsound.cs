using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l : MonoBehaviour
{
   
    [SerializeField] private new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            audio.Play();
        }

    }
}
