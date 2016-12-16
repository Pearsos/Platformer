using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public GameObject rocket;


	void Start () {
	
	}

    void Update () {
	
	}

    public void Attack()
    {
        var r = (GameObject)Instantiate(rocket, new Vector3(2, 0), Quaternion.identity, transform);
        r.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            player.currentWeapon = this;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector3(0.15f, 0.15f);
        }
    }
}
