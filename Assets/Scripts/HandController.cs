using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {

	public OVRInput.Controller Cont;

//	private Vector3 mouseScreenPos;
//	private Vector3 mouseOffset;

//	void OnMouseDown()
//	{
//		Vector3 posTransform = transform.position;

//		mouseScreenPos = Camera.main.WorldToScreenPoint (posTransform);

//		mouseOffset = posTransform - Camera.main.ScreenToWorldPoint(
//			new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouseScreenPos.z));
//	}

//	void OnMouseDrag()
//	{
//		Vector3 curScreenPoint = 
//			new Vector3 (Input.mousePosition.x, Input.mousePosition.y, mouseScreenPos.z);

//		transform.position = Camera.main.ScreenToWorldPoint (curScreenPoint) + mouseOffset;
//	}

	void Update()
	{
		transform.localPosition = OVRInput.GetLocalControllerPosition (Cont);
		transform.localRotation = OVRInput.GetLocalControllerRotation (Cont);
	}

//	void OnTriggerEnter(Collider other)
//	{
//		if (collider.tag == "MusicalObject") {
//
//		}
//	}
}
