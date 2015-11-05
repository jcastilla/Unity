using UnityEngine;
using System.Collections;

public class desaparecerBomba : MonoBehaviour {
	
	public GameObject objeto;
	public bool dentro = false;
	public bool tocaMoneda = false;
	AudioSource audio;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			dentro = true;
			movimiento.puntos -= 5;
			record.puntosMax -= 5;
		}
	}
	
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (dentro == true) {
			
			//audio.Play()
			
			objeto.SetActive(false);
		}
	}
}
