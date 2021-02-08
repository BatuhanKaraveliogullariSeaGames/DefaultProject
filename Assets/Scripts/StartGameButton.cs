using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{

    public void StartButton()
    {
        StartCoroutine(SceneLoader(1));
    }

    IEnumerator SceneLoader(int sceneIndex)
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(sceneIndex);
    }
}
