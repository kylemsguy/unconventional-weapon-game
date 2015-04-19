using UnityEngine;
using System.Collections;

public class SwingAttack : MonoBehaviour, Attack {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DoAttack(float direction)
    {
        // draw circle and see if it intersects with the other player
        float damage = Random.Range(0f, 20f);
        print("Direction: " + direction + "Damage: " + damage);
    }
}
