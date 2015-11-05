using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	static public int puntos = 0;
	//private float velocidad = 2.0f;
	public Rigidbody rb;
	private int pos = 0;
	//private float velocidadInicio = 0.0f;
	bool activo = true;
	public ParticleSystem Particulas;
	private float Tiempo = 0f;
	public bool dentro = false;
	public bool fin = false;
	
	static movimiento Instance;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Particulas.Stop ();
		/*
        if (Instance != null) 
        {
            GameObject.Destroy(gameObject);
        } 
        else 
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }*/
		
		
		//movimiento automatico para delante de la bola
		//rb.AddForce(-velocidadInicio * velocidad, 0, 0);
		//pos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		TocarMoneda ();
		//if (Input.GetKeyDown (KeyCode.Space) && PausarJuego.pause == false) 
		if (Input.GetTouch(0).phase == TouchPhase.Began && PausarJuego.pause == false)
		{
			if (pos == 0)
				pos = 1;
			else if (pos == 1)
				pos = 2;
			else
				pos = 1;
		}
			if(pos == 1 && PausarJuego.pause == false) 
			{
				rb.transform.Translate (Vector3.left * 0.2f);
				activo = true;
			}
			else if(pos == 2 && PausarJuego.pause == false)
			{
				rb.transform.Translate (Vector3.back * 0.2f);
				activo = false;
			}

		if (PausarJuego.pause == true) 
			rb.transform.Translate(0.0f, 0.0f, 0.0f);
		
	}
	
	void TocarMoneda(){
		if (dentro == true) {
			Tiempo = Tiempo + 1 * Time.deltaTime;
			if (Tiempo > 2f) {
				Particulas.Stop ();
				dentro = false;
				Tiempo = 0f;
			}
		}
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Moneda") {
			Particulas.Play ();
			dentro = true;
		}
		
		if (other.gameObject.tag == "Fin") {
			rb.transform.Translate(new Vector3(3.24f,0.19f,0.24f));
			Application.LoadLevel ("mapa2");
			
		}
		if (other.gameObject.tag == "Fin2") {
			Application.LoadLevel ("fin");
			
		}
		/*
        if (other.gameObject.tag == "CaidaFin") {
            Time.timeScale = 1;
            fin = true;
        }*/
		
	}
}
