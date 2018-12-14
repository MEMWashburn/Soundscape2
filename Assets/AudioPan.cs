using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPan : MonoBehaviour {
    public AudioSource _audioSource;
    float sinPan = 0;

	// Use this for initialization
	void Start () {
        _audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        float startRange = -1;    //your chosen start value
        float endRange = 1;    //your chose end value
        var oscilationRange = (endRange - startRange) / 2;
        float oscilationOffset = oscilationRange + startRange;

        sinPan = oscilationOffset + Mathf.Sin(Time.time) * oscilationRange;
        print("Sin Pan: " + sinPan);
        _audioSource.panStereo = sinPan;
	}
}
