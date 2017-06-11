using UnityEngine;
using System.Collections;

public class heard : MonoBehaviour {

    // Use this for initialization
    public int dx = 0;
	void Start () {
        transform.position = new Vector3(transform.position.x + dx*0.6f, transform.position.y , transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
