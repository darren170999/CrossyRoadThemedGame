using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TerrainGenerator terrainGenerator;
    //[SerializeField] private AudioSource audio;
    private Animator animator;
    private bool isHopping;
    private void Start()
    {
        animator = GetComponent<Animator>();
        //audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && !isHopping)
        {
            animator.SetTrigger("hop");
            //audio.Play();
            isHopping = true;
            float zDifference = 0;
            if(transform.position.z % 1 ==0)
            {
                zDifference = Mathf.Round(transform.position.z) -transform.position.z;

            }
            MoveCharacter(new Vector3(1, 0, zDifference));

        }
        else if(Input.GetKeyDown(KeyCode.A) && !isHopping)
        {
            animator.SetTrigger("hop");
            isHopping = true;
            //audio.play();
            MoveCharacter(new Vector3(0, 0, 1));

        }
        else if (Input.GetKeyDown(KeyCode.D) && !isHopping)
        {
            animator.SetTrigger("hop");
            isHopping = true;
            //audio.play();
            MoveCharacter(new Vector3(0, 0, -1));

        }

    }

    private void MoveCharacter(Vector3 difference)
    {
        animator.SetTrigger("hop");
        isHopping = true;
        transform.position = (transform.position + difference);
        terrainGenerator.SpawnTerrain(false, transform.position);
    }


    public void FinishHop()
    {
        isHopping = false;
    }
}
