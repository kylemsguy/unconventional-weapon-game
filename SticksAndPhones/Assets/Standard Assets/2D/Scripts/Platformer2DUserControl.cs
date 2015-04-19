using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

        [SerializeField] private string m_JumpButton = "Jump_P1";
        [SerializeField] private string m_CrouchButton = "Crouch_P1";
        [SerializeField] private string m_HorizontalAxis = "Horizontal_P1";


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown(m_JumpButton);
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = CrossPlatformInputManager.GetButton(m_CrouchButton);//Input.GetKey(KeyCode.S);
            float h = CrossPlatformInputManager.GetAxis(m_HorizontalAxis);
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
