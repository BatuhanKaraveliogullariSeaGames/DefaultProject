using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public ItemObject currentWeapon;
    public Image weaponImage;
    [SerializeField] private GameObject undoButton;

    private void Update()
    {
        if (currentWeapon != null)
        {
            weaponImage.sprite = currentWeapon.weaponSprite;

            undoButton.SetActive(true);
        }
        else
        {
            weaponImage.sprite = null;

            undoButton.SetActive(false);
        }
            

    }
}
