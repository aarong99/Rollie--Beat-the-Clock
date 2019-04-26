using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class clickSound : MonoBehaviour {

	public AudioClip sound;
	private AudioSource source { get { return GetComponent<AudioSource>(); } }
	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource>();
		source.clip = sound;
	}
	
	// Update is called once per frame
	void PlaySound () {
		source.PlayOneShot(sound);
	}
}
