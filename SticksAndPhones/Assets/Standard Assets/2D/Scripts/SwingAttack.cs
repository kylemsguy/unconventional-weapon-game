using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class SwingAttack : MonoBehaviour, Attack {

    private PlatformerCharacter2D player;
    [SerializeField] private BoxCollider2D other;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DoAttack(int type, BoxCollider2D coll)
    {
        // draw circle and see if it intersects with the other player
        float damage = Random.Range(0f, 20f);
        print("a");
        if (coll.IsTouching(other))
        {
            player = other.GetComponentInParent<PlatformerCharacter2D>();
            player.Damage(damage);
            print("b");

        }

    }
}
