using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypoingIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if(Vector2.Distance(waypoints[currentWaypoingIndex].transform.position, transform.position) < .1f)
        {
            currentWaypoingIndex++;
            if (currentWaypoingIndex >= waypoints.Length)
            {
                currentWaypoingIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoingIndex].transform.position, Time.deltaTime * speed);
    }
}
