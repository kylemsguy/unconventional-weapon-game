using UnityEngine;
using System.Collections;

public interface Attack {
    void DoAttack(int type, BoxCollider2D coll);
}
