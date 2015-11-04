using UnityEngine;
using System.Collections;

public class PausarJuego : MonoBehaviour {
	
	static public bool pause = false;
	public  GUITexture pauseGUI;
	//public Texture2D salir;
	string nivel;
	
	void Start()
	{
		pauseGUI.enabled = false;
	}
	
	void Update(){          
		if(pause == false) 
		{
			Time.timeScale = 1;
			pauseGUI.enabled = true;
			pause = true;
			//Screen.showCursor = true;
			
		}
		else {
			Time.timeScale = 0;
			pauseGUI.enabled = false;
			pause = false;
			//Screen.showCursor = false;
		}
		nivel = Application.loadedLevelName;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "CaidaFin") 
		{
			pause = true;
		}
		
	}
	
	void OnGUI()
	{
		if(pause==true || nivel == "fin")
		{
			if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height /2.5f, Screen.width/3, Screen.height/5), "REINICIAR")) //si pulsamos el boton en true, sino false
			{
				if(puntuacion.puntos > record.puntosMax )
					record.puntosMax = puntuacion.puntos;
				else
					record.puntosMax = record.puntosMax;

				movimiento.puntos = 0;
				Application.LoadLevel("mapa1");
				pause = false;
			}
		}
		
	}
}