using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory System/Item")]
public class ItemObject : ScriptableObject
{
    public GameObject prefab;//select edilen gunun özelliklerini taşıyan container
    public Sprite weaponSprite;
}

