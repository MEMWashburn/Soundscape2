using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeqSpawn : MonoBehaviour {
    public GameObject[] smackables;
    public Transform[] smackPoints;
    public float beat = 1.14285714286f; // (60 / 105) * 2;
    private float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > beat)
        {
            GameObject smack = Instantiate(smackables[Random.Range(0, 2)], smackPoints[Random.Range(0, 4)]);
            smack.transform.localPosition = Vector3.zero;
            smack.transform.Rotate(transform.forward, 67.5f); // 90 - (45 / 2));
            smack.transform.Rotate(transform.up, 90);
            timer -= beat;
        }

        timer += Time.deltaTime;
	}
}
