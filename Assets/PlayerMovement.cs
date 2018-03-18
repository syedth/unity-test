using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	
	// Use Fixed Update when Using Physics
	void FixedUpdate () {
		rb.AddForce(0 , 0, 2000 * Time.deltaTime);

	}
}
