using UnityEngine;
using System.Collections;

public class PatrolMovement : MonoBehaviour
{
    Vector3 direction = new Vector3();

    void Start()
    {

    }

   
    void Update()
    {
        transform.position += direction * Time.deltaTime;
        if (transform.position.x <= 0)
        {
            direction = new Vector3(1, .5f);
        }
        if (transform.position.x >= 500)
        {
            direction = new Vector3(-1, -.5f);
        }
    }
}
