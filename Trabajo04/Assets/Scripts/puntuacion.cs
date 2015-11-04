using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class puntuacion : MonoBehaviour {

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
		text.text = "Puntuacion: " + movimiento.puntos;
		puntos = movimiento.puntos;
	}
}
