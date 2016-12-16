using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {
    const float DEAD_ZONE_HEIGHT = -5;
    const float THRESHOLD = .2f;

    public float maxspeed = 3;
    public float jumpforce = 5;

    private bool isDucking = false;

    private Vector3 startPosition;
    private new Rigidbody2D rigidbody2D;

    void Start() {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < DEAD_ZONE_HEIGHT)
        {
          Die();
        }

        var x_force = Input.GetAxis("Horizontal");
        rigidbody2D.velocity += Vector2.right * x_force;
        rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxspeed);

        if (Input.GetButtonDown ("Jump") && rigidbody2D.velocity.y == 0)
        {
            rigidbody2D.velocity += Vector2.up * jumpforce;
        }

        if (input.GetButtonDown("Fire1") && currentWeapon != null)
        {
            currentWeapon.Attack();
        }

        //Duck if needed
        if (Input.GetAxis("Vertical") < 0 && !isDucking)
        {
            var s = transform.localScale;
            s.y *= .7f;
            transform.localScale *= .7f;
            isDucking = true;
        }

        if (Input.GetAxis("Vertical") >= 0 && isDucking)
        {
            var s = transform.localScale;
            s.y /= .7f;
            transform.localScale /= .7f;
            isDucking = false;
        }

        // flip to look in right direction
        if (rigidbody2D.velocity.x > THRESHOLD)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        if (rigidbody2D.velocity.x < -THRESHOLD)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }

    public void Die()
    {
        transform.position = startPosition;
        rigidbody2D.velocity = new Vector2();
        FindObjectOfType<GM> ().LifeLost();
    }
}
