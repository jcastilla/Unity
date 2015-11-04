using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class record : MonoBehaviour {

	static public int puntosMax = 0;
	public static int puntos;
	Text text;
	
	void Awake()
	{
		text = GetComponent <Text> ();
		puntos = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (puntosMax < puntuacion.puntos) {
			text.text = "Record: " + puntuacion.puntos;
			puntosMax = puntuacion.puntos;
			text.color = Color.red;
		} else {
			text.text = "Record: " + puntosMax;

		}


	}
}
