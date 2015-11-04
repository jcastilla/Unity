using UnityEngine;
using System.Collections;

public class terreno : MonoBehaviour {

	public bool dentro = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			dentro = true;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (dentro == true) 
		{
			GUILayout.Label("FIN");
			//Time.timeScale = 0;
			//rb.transform.Translate(new Vector3(3.24f,0.19f,0.24f));

			//gameObject.transform.Translate(new Vector3(0,-1,0));
			//Destroy (this, 1f);
		} 
	}
}
