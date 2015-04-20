using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;
    
public class HPController : MonoBehaviour {

    [SerializeField] private PlatformerCharacter2D player1;
    [SerializeField] private PlatformerCharacter2D player2;

	// Use this for initialization
	void Awake() {
        player1 = (PlatformerCharacter2D)GameObject.Find("Player1").GetComponent<PlatformerCharacter2D>();
        player2 = (PlatformerCharacter2D)GameObject.Find("Player2").GetComponent<PlatformerCharacter2D>();
	}
	
	// Update is called once per frame
	void Update() {
        transform.Find("HP_P1").Find("HPBar").transform.localScale = new Vector3(player1.GetHealth() / 100, 1, 1);
        transform.Find("HP_P2").Find("HPBar").transform.localScale = new Vector3(player2.GetHealth() / 100, 1, 1);
	}
}
