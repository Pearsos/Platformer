using UnityEngine;
using System.Collections;

public class FlyingMovement : MonoBehaviour
{
    public Vector3[] waypoints;
    private int waypointIndex = 0;
    const float distance = .1f;

    void Start()
    {

    }

 
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, waypoints[waypointIndex], Time.deltaTime);
        if (Vector3.Distance(transform.position, waypoints[waypointIndex]) < distance)
        {
            waypointIndex++;
            waypointIndex = waypointIndex % waypoints.Length;
        }
    }
}
