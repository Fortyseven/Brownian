using UnityEngine;
using System.Collections;

public class MoleculeA : MonoBehaviour
{
	private float MAXSPEED = 500.0f;

	void Start ()
	{
		rigidbody2D.AddForce (new Vector2 (Random.Range (-MAXSPEED, MAXSPEED), Random.Range (-MAXSPEED, MAXSPEED)));
	}
}
