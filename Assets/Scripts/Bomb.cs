using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {


	void Start () {
	
	}
	

	void Update ()
    {
	
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var enemies = FindObjectsOfType<Enemy>();
        foreach(var e in enemies)
        {
            e.gameObject.SetActive(false);
        }
    }

}
