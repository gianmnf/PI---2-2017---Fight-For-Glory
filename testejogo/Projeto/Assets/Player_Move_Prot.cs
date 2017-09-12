using UnityEngine;
using System.Collections;

public class Player_Move_Prot : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = true;
	public int playerJumpPower = 1250;
	private float moveX;
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();
	}
	void PlayerMove(){
		//Controles
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
		//Animações
		//Direção
		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer ();
		} else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer ();
		}
		//Física
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
}
	void Jump(){
	//Código de Pulo
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
}
	void FlipPlayer(){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}