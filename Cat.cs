using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Transform[] waypoints;
    private int waypointIndex;
    private float dist;
    public int SprintingSpeed;
    // Update is called once per frame
    private void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);

    }
    private void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }

    private void Patrol()
    {
        transform.Translate(Vector3.forward * SprintingSpeed * Time.deltaTime);

    }
    private void IncreaseIndex()
    {
        waypointIndex++;
        if(waypointIndex>= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }

}
