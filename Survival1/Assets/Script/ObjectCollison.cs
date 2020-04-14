using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollison : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "ObjectMusuh")
		{
			Debug.Log("Collide!");
			AudioSource aud = gameObject.GetComponent<AudioSource>();
			aud.Play();
			col.gameObject.SetActive(false);
		}
	}
}
