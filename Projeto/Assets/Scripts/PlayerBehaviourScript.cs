using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

<<<<<<< HEAD
	private Rigidbody2D rb;
=======
	private Rigidbody2D rd;
>>>>>>> c2652efce8430faa35561987482a84e82333650e
	private Transform tr;
	private Animator an;
	public Transform verificaChao;
	public Transform verificaParede;

	private bool estaAndando;
	private bool estaNoChao;
	private bool estaNaParede;
	private bool estaVivo;
<<<<<<< HEAD
=======
	private bool estaPulando;
>>>>>>> c2652efce8430faa35561987482a84e82333650e
	private bool viradoParaDireita;

	private float axis;
	public float velocidade;
	public float forcaPulo;
	public float raioValidaChao;
	public float raioValidaParede;

	public LayerMask solido;


	// Use this for initialization
	void Start () {

<<<<<<< HEAD
		rb = GetComponent<Rigidbody2D> ();
=======
		rd = GetComponent<Rigidbody2D> ();
>>>>>>> c2652efce8430faa35561987482a84e82333650e
		tr = GetComponent<Transform> ();
		an = GetComponent<Animator> ();

		estaVivo = true;
		viradoParaDireita = true;

	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		estaNoChao = Physics2D.OverlapCircle (verificaChao.position, raioValidaChao, solido);
		estaNaParede = Physics2D.OverlapCircle (verificaParede.position, raioValidaParede, solido);

		if(estaVivo){
		
		axis = Input.GetAxisRaw ("Horizontal");

		estaAndando = Mathf.Abs (axis) > 0f;
=======
		estaNoChao = Physics2D.OverlapCircle(verificaChao.transform, raioValidaChao, solido);
		estaNaParede = Physics2D.OverlapCircle(verificaParede.transform, raioValidaParede, solido);

		if (estaNoChao)
			estaPulando = false;
		
		axis = Input.GetAxisRaw ("Horizontal");

		estaAndando = Matf.Abs (axis) > 0f;
>>>>>>> c2652efce8430faa35561987482a84e82333650e

		if (axis > 0f && !viradoParaDireita)
			Flip ();
		else if (axis < 0f && viradoParaDireita)
			Flip ();

<<<<<<< HEAD
		if (Input.GetButtonDown ("Jump") && estaNoChao)
			rb.AddForce (tr.up * forcaPulo);
	}
	}

	void FixedUpdate(){
=======
		if (input.GetButtonDown ("Jump") && estaNoChao)
			estaPulando = true;
		
	}

	void FixedUpdate(){

		if (estaPulando)
			rb.AddForce (tr.up * forcaPulo);

>>>>>>> c2652efce8430faa35561987482a84e82333650e
		if (estaAndando && !estaNaParede) {

			if (viradoParaDireita)
				rb.velocity = new Vector2 (velocidade, rb.velocity.y);
			else
				rb.velocity = new Vector2 (-velocidade, rb.velocity.y);
		}
			
	}

	void Flip(){

		viradoParaDireita = !viradoParaDireita;

		tr.localScale = new Vector2 (-tr.localScale.x, tr.localScale.y);
	}
<<<<<<< HEAD
		
	void OnDrawGizmosSelected(){
		Gizmos.color = Color.red;

		Gizmos.DrawWireSphere (verificaChao.position, raioValidaChao);
		Gizmos.DrawWireSphere (verificaParede.position, raioValidaParede);
	}
=======
>>>>>>> c2652efce8430faa35561987482a84e82333650e
}
