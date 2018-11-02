using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLeaf2 : MonoBehaviour {
	
	void PlaySound(string path)
	{
		FMODUnity.RuntimeManager.PlayOneShot (path, GetComponent<Transform>().position);
	}

	private void Vibrate()
	{
		iTween.PunchScale (gameObject, iTween.Hash(
			"x",	0.15,
			"y",	0.15,
			"z",	0.15,
			"time",	2.5)
		);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Hand") {
			Vibrate ();
			PlaySound ("event:/SFX/Tree1/HangDrum (2)");
		}
	}
}
