using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    private Player player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
        offset = transform.position - player.transform.position;
        Debug.Log(offset);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
	    
	}
}