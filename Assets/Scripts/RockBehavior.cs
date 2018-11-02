using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour {

//	void PlaySound(string path)
//	{
//		FMODUnity.RuntimeManager.PlayOneShot (path, GetComponent<Transform>().position);
//	}

	private void Vibrate()
	{
		iTween.PunchPosition (gameObject, iTween.Hash(
			"x",	0.15,
			"z",	0.15,
			"time",	1.5)
		);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Hand") {
//			PlaySound ("event:/SFX/Tree1/HangDrum (2)");
			Vibrate ();
		}
	}
}
