using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textoFinal : MonoBehaviour {

	Text text;

	void Awake()
	{
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "!!!ENHORABUENA!!!  \n\n Has completado el juego";
	}
}
