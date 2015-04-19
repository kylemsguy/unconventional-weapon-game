using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class FighterCharacter : PlatformerCharacter2D {
    public override void Attack(int type)
    {
        // draw circle and see if it intersects with the other player
        float damage = Random.Range(0f, 20f);
        print(damage);
    }

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void FixedUpdate() { base.FixedUpdate(); }
}
