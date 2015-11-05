using UnityEngine;
using System.Collections;

public class bombardeo1 : MonoBehaviour {
	
	public GameObject prefab;
	public int cont = 0;

	
	// Use this for initialization
	void Start () {
		float x = Random.Range (1f, 5f);
		InvokeRepeating ("bombardear", x, 3f);
	}

	void bombardear () {
		GameObject bomba = Instantiate (prefab, transform.position, transform.rotation) as GameObject;

		bomba.name = "bomba" + cont++;
		
		FisicaBomba fisica = bomba.GetComponent<FisicaBomba> ();
		
		fisica.disparar ();
		
		Destroy (bomba, 5f);
	}

	// Update is called once per frame
	void Update () {

		
	}
}