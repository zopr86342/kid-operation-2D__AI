using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relife : MonoBehaviour {

    public GameObject mouse;
    float t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        t += Time.deltaTime;
        if (t >= 1)
        {
            Instantiate(mouse, transform.position, transform.rotation);
            t = 0;
            return;
        }
        
	}
}
