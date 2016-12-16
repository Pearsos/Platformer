using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{


    public int THRESHOLD = 1;

	void Start () {
	
	}
   
	void Update ()
    {

        // flip to look in right direction
        if (GetComponent<Rigidbody2D>().velocity.x > THRESHOLD)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        if (GetComponent<Rigidbody2D>().velocity.x < -THRESHOLD)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }

    }

    public void onCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if(player != null)
        {
            player.Die();
        }
    }
}
