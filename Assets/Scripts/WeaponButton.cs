using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponButton : MonoBehaviour
{
    [SerializeField] private InventoryObject playerInGameInventory;
    private List<GameObject> weapons;

    private void OnEnable()
    {
        if(playerInGameInventory.itemHolder.Count > 0)
        {
            weapons = new List<GameObject>();

            for (int i = 0; i < playerInGameInventory.itemHolder.Count; i++)
            {
                weapons.Add(Instantiate(playerInGameInventory.itemHolder[i].prefab, new Vector3(-2.5f + (2.5f*i), 0f, 0f), Quaternion.identity));
            }

            for (int i = 0; i < weapons.Count; i++)
            {
                weapons[i].SetActive(false);
            }
        }
    }

    public void WeaponButtonUI(Button button)
    {
        if(button.name == "Weapon1")
        {
            weapons[0].gameObject.SetActive(true);
            weapons[1].gameObject.SetActive(false);
            weapons[2].gameObject.SetActive(false);
        }
        else if(button.name == "Weapon2")
        {
            weapons[0].gameObject.SetActive(false);
            weapons[1].gameObject.SetActive(true);
            weapons[2].gameObject.SetActive(false);
        }
        else if(button.name == "Weapon3")
        {
            weapons[0].gameObject.SetActive(false);
            weapons[1].gameObject.SetActive(false);
            weapons[2].gameObject.SetActive(true);
        }
    }
}