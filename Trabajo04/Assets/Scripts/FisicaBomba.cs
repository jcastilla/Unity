using UnityEngine;
using System.Collections;

public class FisicaBomba : MonoBehaviour {

	float velocidad = 10;

	//public Rigidbody rb = GetComponent<Rigidbody>(); 
	// Use this for initialization
	public void disparar () {
		//GetComponent<Rigidbody>().Sleep ();
		//transform.Translate (Vector3.forward * velocidad * Time.deltaTime);
		GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,1f) * velocidad, ForceMode.Impulse);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

