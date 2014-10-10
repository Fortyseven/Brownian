using UnityEngine;
using System.Collections;

public class SimInit : MonoBehaviour
{
	private const int MAX_MOLECULES = 1500;

	public GameObject MoleculeAPrefab;
	public  GameObject Walls;

	private ArrayList _moleculesA;

	void Start ()
	{
		_moleculesA = new ArrayList ();

		for (var i = 0; i < MAX_MOLECULES; i++) {
			Vector3 pos = new Vector3 (
						Random.Range (-9, 9) + (Random.Range (0, 1000) / 1000), 
						Random.Range (-9, 9) + (Random.Range (0, 1000) / 1000), 
						0);
			_moleculesA.Add (Instantiate (MoleculeAPrefab, pos, Quaternion.identity));
		}
	}

	void Update()
	{
		if (Input.anyKeyDown) {
			Walls.SetActive(!Walls.activeInHierarchy);
		}
	}
}
