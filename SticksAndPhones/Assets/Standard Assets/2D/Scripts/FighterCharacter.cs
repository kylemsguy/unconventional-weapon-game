using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class FighterCharacter : PlatformerCharacter2D {
    public override void Attack(int type)
    {
        m_attack.DoAttack(0);
    }

    protected override void Awake() { base.Awake(); }
    protected override void FixedUpdate() { base.FixedUpdate(); }
}
