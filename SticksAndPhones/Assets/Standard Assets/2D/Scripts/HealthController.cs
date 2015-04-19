using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class HealthController : MonoBehaviour
    {
        private PlatformerCharacter2D player1;
        private PlatformerCharacter2D player2;

        private void Awake()
        {
            GetComponent<PlatformerCharacter2D>();
        }
    }
}
