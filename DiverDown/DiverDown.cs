using UnityEngine;
using Winch.Core;

namespace DiverDown
{
	public class DiverDown : MonoBehaviour
	{
        public static object HarvestPOIflag2 { get; internal set; }

        public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(DiverDown)} has loaded!");
		}
	}
}
