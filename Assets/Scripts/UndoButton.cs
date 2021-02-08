using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoButton : MonoBehaviour
{
    private Slot slot;

    private void Start()
    {
        slot = GetComponentInParent<Slot>();
    }

    public void UndoButtonUI()
    {
        slot.currentWeapon = null;
        slot.weaponImage.sprite = null;
    }
}
