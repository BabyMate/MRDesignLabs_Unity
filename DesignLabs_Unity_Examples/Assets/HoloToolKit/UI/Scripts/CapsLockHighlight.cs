﻿using UnityEngine;
using UnityEngine.UI;

namespace HoloToolkit.UI.Keyboard
{
	public class CapsLockHighlight : MonoBehaviour
	{
		/// <summary>
		/// The highlight image to turn on and off.
		/// </summary>
		[SerializeField]
		private Image m_Highlight;

		/// <summary>
		/// The keyboard to check for caps locks
		/// </summary>
		private Keyboard m_Keyboard;

		
		/// <summary>
		/// Unity Start method.
		/// </summary>
		private void Start()
		{
			m_Keyboard = this.GetComponentInParent<Keyboard>();
			this.UpdateState();
		}

		/// <summary>
		/// Unity update method.
		/// </summary>
		private void Update()
		{
			this.UpdateState();
		}

		/// <summary>
		/// Updates the visual state of the shift highlight.
		/// </summary>
		private void UpdateState()
		{
			bool isCapsLock = false;
			if (m_Keyboard != null)
			{
				isCapsLock = m_Keyboard.IsCapsLocked;
			}

			if (m_Highlight != null)
			{
				m_Highlight.enabled = isCapsLock;
			}
		}
	}
}
