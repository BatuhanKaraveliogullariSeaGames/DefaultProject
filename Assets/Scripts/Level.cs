using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private GameObject levelSelectionCanvas;
    [SerializeField] private GameObject weaponSelectionCanvas;

    public void LevelSelecter()
    {
        StartCoroutine(ChangeCanvas(levelSelectionCanvas, weaponSelectionCanvas));
    }

    IEnumerator ChangeCanvas(GameObject activeCanvas, GameObject deactiveCanvas)
    {
        yield return new WaitForSeconds(0.5f);

        if (activeCanvas.activeInHierarchy)
            activeCanvas.SetActive(false);

        if (!deactiveCanvas.activeInHierarchy)
            deactiveCanvas.SetActive(true);
    }
}
