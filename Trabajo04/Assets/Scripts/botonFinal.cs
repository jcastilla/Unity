using UnityEngine;
using System.Collections;

public class botonFinal : MonoBehaviour {

	//public GameObject boton;

	public void reiniciarPartida()
	{
		movimiento.puntos = 0;
		Application.LoadLevel("mapa1");
		//Vector randomSpawn = new Vector3(Random.Range(-7.8f, 3.37f), Random.Range(5.04f, -3.08f), 0);
		//Instantiate (boton, randomSpawn, transform.rotation);
	}
}
