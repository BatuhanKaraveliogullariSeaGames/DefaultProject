using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponLand : RecyclingListViewItem
{
    /*
     *Canvasta scroll viewdeki content içerisinde göstrilen weapon bord prefabı
     */

    public ItemObject weapon;//weapon scritable objesi prefab ve sprite tutuyor.
    public Image descriptionImage;//prefabın childi olarak tutuğu image objesi  
    private GameObject[] slots;//select edilen weapon bordun bilgileri göndereceği slotlar

    void Start()
    {
        descriptionImage.sprite = weapon.weaponSprite;//childi olarak tutulan image a aldığı weapon scriptable objesinin sprite propertiysini atama

        slots = GameObject.FindGameObjectsWithTag("Slot");//scenedeki slotları bulma
    }

    public void SelectButton()
    {
        /*
         * scenedeki boş olan slot objesine atama yapma button function
         */

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].GetComponent<Slot>().currentWeapon == null)
            {
                slots[i].GetComponent<Slot>().currentWeapon = weapon;
                break;
            }
        }
    }
}
