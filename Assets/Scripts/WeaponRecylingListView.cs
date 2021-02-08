using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponRecylingListView : MonoBehaviour
{
    public class ItemInformation
    {
        public ItemObject itemObject;

        public ItemInformation(ItemObject _itemObject)
        {
            itemObject = _itemObject;
        }
    }

    [SerializeField] private GameObject weaponSelectionCanvas;
    [SerializeField] private GameObject inGameCanvas;
    [SerializeField] private List<Slot> slots;
    [SerializeField] private InventoryObject inventoryInMenu;
    [SerializeField] private InventoryObject inventoryInGame;
    [SerializeField] private RecyclingListView scrollView;
    private List<ItemInformation> itemInformations;
    private ScrollRect scrollRect;

    void Start()
    {
        scrollRect = scrollView.GetComponent<ScrollRect>();

        scrollRect.velocity = new Vector2(0f,0f);

        itemInformations = new List<ItemInformation>(inventoryInMenu.itemHolder.Count);

        for (int i = 0; i < inventoryInMenu.itemHolder.Count; i++)
        {
            itemInformations.Add(new ItemInformation(inventoryInMenu.itemHolder[i]));
        }

        scrollView.ItemCallback = UpdateItem;

        scrollView.RowCount = itemInformations.Count;

        scrollRect.horizontalScrollbarSpacing = scrollRect.horizontalScrollbarSpacing;
    }

    private void Update()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if(i <= slots.Count-2)
            {
                if (slots[i].currentWeapon == null)
                {
                    if (slots[i + 1].currentWeapon != null)
                    {
                        slots[i].currentWeapon = slots[i + 1].currentWeapon;
                        slots[i + 1].currentWeapon = null;
                    }
                }
            }
        }
    }

    private void UpdateItem(RecyclingListViewItem i, int index)
    {
        WeaponLand item = (WeaponLand)i;

        item.descriptionImage.sprite = itemInformations[index].itemObject.weaponSprite;
        item.weapon = itemInformations[index].itemObject;
    }

    public void ReadyButton()
    {
        //dolu olan slotları playerın oyun içinde kullanacağı scriptable objeye ekleme işlemi
        for (int i = 0; i < slots.Count; i++)
        {
            if(slots[i].currentWeapon != null)
            {
                inventoryInGame.itemHolder.Insert(i, slots[i].currentWeapon);
            }
            else
            {
                Debug.Log("You have empty slot.");
            }
        }

        weaponSelectionCanvas.SetActive(false);
        inGameCanvas.SetActive(true);
        //weaponselection canvas deactive ingame canvas active oluyor
    }
}
