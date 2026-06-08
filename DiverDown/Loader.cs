using UnityEngine;

namespace DiverDown
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(DiverDown));
			gameObject.AddComponent<DiverDown>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}