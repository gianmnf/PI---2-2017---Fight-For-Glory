using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

	private Rigidbody2D rd;
	private Transform tr;
	private Animator an;
	public Transform verificaChao;
	public Transform verificaParede;

	private bool estaAndando;
	private bool estaNoChao;
	private bool estaNaParede;
	private bool estaVivo;
	private bool estaPulando;
	private bool viradoParaDireita;

	private float axis;
	public float velocidade;
	public float forcaPulo;
	public float raioValidaChao;
	public float raioValidaParede;

	public LayerMask solido;


	// Use this for initialization
	void Start () {

		rd = GetComponent<Rigidbody2D> ();
		tr = GetComponent<Transform> ();
		an = GetComponent<Animator> ();

		estaVivo = true;
		viradoParaDireita = true;

	}
	
	// Update is called once per frame
	void Update () {
		estaNoChao = Physics2D.OverlapCircle(verificaChao.transform, raioValidaChao, solido);
		estaNaParede = Physics2D.OverlapCircle(verificaParede.transform, raioValidaParede, solido);

		if (estaNoChao)
			estaPulando = false;
		
		axis = Input.GetAxisRaw ("Horizontal");

		estaAndando = Matf.Abs (axis) > 0f;

		if (axis > 0f && !viradoParaDireita)
			Flip ();
		else if (axis < 0f && viradoParaDireita)
			Flip ();

		if (input.GetButtonDown ("Jump") && estaNoChao)
			estaPulando = true;
		
	}

	void FixedUpdate(){

		if (estaPulando)
			rb.AddForce (tr.up * forcaPulo);

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
}
