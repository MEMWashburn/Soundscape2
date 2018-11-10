using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Midi_Arp : MonoBehaviour {
    public Color ObjectColor;
    private Color curCol;
    private Material matCol;

    private AudioChorusFilter acf;
    private AudioHighPassFilter ahpf;
    private AudioLowPassFilter alpf;
    private AudioReverbFilter arf;
    private AudioEchoFilter aef;
    private AudioDistortionFilter adf;
    public AudioSource asrc;

    public KeyCode key;
    bool active = false;
    GameObject hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key))//&& active
        {
            asrc.Play();

            print(key);
            //helps stop memory leaks
            if (matCol != null)
                UnityEditor.AssetDatabase.DeleteAsset(UnityEditor.AssetDatabase.GetAssetPath(matCol));

            //create a new material
            matCol = new Material(Shader.Find("Diffuse"));
            Color c = Random.ColorHSV();
            matCol.color = curCol = ObjectColor = c;
            this.GetComponent<Renderer>().material = matCol;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        //active == true ? active = false : active = true;
        if (active) { active = false; }
        else        { active = true; }
        if (other.gameObject.CompareTag("Hand")) {
            hand = other.gameObject;
            Destroy(other.gameObject);
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    active = false;
    //}
}
