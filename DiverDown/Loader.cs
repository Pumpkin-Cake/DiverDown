using System;
using UnityEngine;
using Winch.Util;
//Above is default. Below is extras
using Google.Protobuf.WellKnownTypes;
using System.Linq;
using UnityEngine.AI;
using Winch.Core;
using Winch.Data.Shop;
using Yarn;

namespace DiverDown
{
    public class Loader
    {
        public static string BasePath => ModAssemblyLoader.GetCurrentMod().BasePath;
        public static ItemData DiverOne => ItemUtil.GetModdedItemData("DiverDown.diver1");   //Get the Diver1 item in Assets/Items/General
        public static HarvestPOI DiverCreatedPOI1 => (HarvestPOI)PoiUtil.GetCreatedModdedPOI("DiverDownHarvestPOIflag");
        //public static VibrationData DiverOneVibrationData => VibrationUtil.GetModdedVibrationData("DiverDown.diver1");
        /// <summary>
        /// This method is run by Winch to initialize your mod
        /// </summary>
        public static void Initialize()
        {
            var gameObject = new GameObject(nameof(DiverDown));
            gameObject.AddComponent<DiverDown>();
            GameObject.DontDestroyOnLoad(gameObject);

            //   ApplicationEvents.Instance.OnGameLoaded += OnGameLoaded;
            GameManager.Instance.OnGameStarted += OnGameStarted;
            GameManager.Instance.OnGameEnded += OnGameEnded;
        }

        //private static void OnGameLoaded()
        //{
        //
        //}
        private static void OnGameStarted()
        {
            //    GameManager.Instance.SaveData.SetBoolVariable("exampleitems.explosive-detonated", val: false); // for testing

            GameEvents.Instance.OnSpecialItemHandlerRequested += OnSpecialItemHandlerRequested;
        }

        private static void OnGameEnded()
        {
            GameEvents.Instance.OnSpecialItemHandlerRequested -= OnSpecialItemHandlerRequested;
        }

        private static void OnSpecialItemHandlerRequested(SpatialItemData itemData)
        {
            if (itemData.id == DiverOne.id) // Use the Diver item declared in Line 17
            {
                GameManager.Instance.UI.ShowNotification(NotificationType.ITEM_HANDED_IN, "DiverDown.diverdeployed.notif");  // Give a notification with the string, "Diver deployed"
                GameManager.Instantiate(DiverCreatedPOI1, new Vector3(82, 0, -81)); // NOT WORKING ; create a Point of Interest (POI) declared in Line 18.
            }

        }
    }

}
