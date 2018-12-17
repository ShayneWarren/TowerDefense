using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddTowerWindow : MonoBehaviour {

    public GameObject towerSlotToAddTowerTo;

    public void Addtower(string towerTypeAsString)
    {
        TowerType type = (TowerType)Enum.Parse(typeof(TowerType), towerTypeAsString);

        if (TowerManager.Instance.GetTowerPrice(type) <= GameManager.Instance.gold)
        {
            GameManager.Instance.gold -= TowerManager.Instance.GetTowerPrice(type);

            TowerManager.Instance.CreateNewtower(towerSlotToAddTowerTo, type);
            gameObject.SetActive(false);
        }
    }

	
}
