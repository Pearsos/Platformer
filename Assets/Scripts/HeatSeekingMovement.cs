using UnityEngine;
using System.Collections;

public class HeatSeekingMovement : MonoBehaviour
{
    public Transform target;
  
    void Start()
    {
        if (target = null)
        {
            target = FindObjectOfType<Player>().transform;
        }
    }


    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, target.position, Time.deltaTime);
    }
}
