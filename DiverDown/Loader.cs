using System;
using UnityEngine;
using Winch.Util;

namespace DiverDown
{
    public class Loader
    {

        public static ItemData DiverOne => ItemUtil.GetModdedItemData("DiverDown.diver1");
        public static VibrationData MilkBucketVibrationData => VibrationUtil.GetModdedVibrationData("DiverDown.diver1");
        /// <summary>
        /// This method is run by Winch to initialize your mod
        /// </summary>
        public static void Initialize()
        {
            var gameObject = new GameObject(nameof(DiverDown));
            gameObject.AddComponent<DiverDown>();
            GameObject.DontDestroyOnLoad(gameObject);
        }

        private static void OnSpecialItemHandlerRequested(SpatialItemData itemData)
        {
            if (itemData.id == DiverOne.id) // Use the Diver
            {

            
            GameManager.Instance.ItemManager.UseRepairKit();
            GameManager.Instance.ItemManager.RepairAllItemDurability();
            GameManager.Instance.UI.OccasionalGridPanel.TryRepairCurrentCrabPot();
            GameManager.Instance.UI.ShowNotification(NotificationType.ANY_REPAIR_KIT_USED, "notification.durability-repaired");
            GameManager.Instance.Player.Sanity.ChangeSanity(1f);
            GameManager.Instance.UI.ShowNotification(NotificationType.ANY_REPAIR_KIT_USED, "notification.panic-repaired");
            GameManager.Instance.VibrationManager.Vibrate(MilkBucketVibrationData, VibrationRegion.WholeBody, overrideExistingVibrations: true);
             }


            // GameManager.Instance.UI.ShowNotification(NotificationType.ITEM_REMOVED, "DiverDown.diverdeployed.notif");
            //  GameManager.Instantiate(DiverDown.HarvestPOIflag2, (new Vector3(82, 0, -81)));
            
        }
    }
    }

