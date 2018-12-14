using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeqSpawn : MonoBehaviour {
    public GameObject[] smackables;
    public Transform[] smackPoints;
    public float beat = 1.14285714286f; // (60 / 105) * 2;
    private float timer;
    public float[] _bpms;
    public int song;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // returns true if the primary button (typically “A”) is currently pressed.
        if ((OVRInput.Get(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A)) && song < _bpms.Length)
        {
            song++;
            if (song > _bpms.Length - 1) song = 0; // wrap down
            print("Song bpm: " + song);
            beat = (60.0f /_bpms[song]) / 2.0f;
        }

        // returns true if the primary button (typically “X”) is currently pressed.
        if ((OVRInput.Get(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.X)) && song >= 0)
        {
            song--;
            if (song < 0) song = _bpms.Length - 1; // wrap up
            print("Song bpm: " + song);
            beat = (60.0f / _bpms[song]) / 2.0f;
        }

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
