
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private void Awake()
    {
        if (Application.isEditor == false)
        {
            Debug.unityLogger.logEnabled = false;
        }
    }


    public void LoadScenes(string name)
    {
        SceneManager.LoadScene(name);
    }
}
