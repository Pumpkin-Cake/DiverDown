using UnityEngine;
using Winch.Core;

namespace DiverDown
{
	public class DiverDown : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(DiverDown)} has loaded!");
		}
	}
}
