using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smacker : MonoBehaviour {

    public LayerMask layer;
    public Vector3 prevPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit smack;

        if (Physics.Raycast(transform.position, transform.forward, out smack, 1, layer))
        {
            if (Vector3.Angle(transform.position - prevPos, smack.transform.up) > 130) {
                Destroy(smack.transform.gameObject);
            }
        }
        prevPos = transform.position;
	}
}
