using UnityEngine;

public class MoleculeA : MonoBehaviour
{
    private const float MAXSPEED = 500.0f;

    public void Start()
    {
        GetComponent<Rigidbody2D>().AddForce( new Vector2( Random.Range( -MAXSPEED, MAXSPEED ), Random.Range( -MAXSPEED, MAXSPEED ) ) );
    }
}
