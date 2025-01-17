using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : MonoBehaviour
{
    public float velocity;
    public Transform[] waypoints;


    private int current;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position != waypoints[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, waypoints[current].position, velocity * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % waypoints.Length;
    }
}
