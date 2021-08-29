using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] int timeToWaitBeforeLoad = 4;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(DelayThenLoadNextScene());
        }
    }

    private IEnumerator DelayThenLoadNextScene()
    {
        yield return new WaitForSeconds(timeToWaitBeforeLoad);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
