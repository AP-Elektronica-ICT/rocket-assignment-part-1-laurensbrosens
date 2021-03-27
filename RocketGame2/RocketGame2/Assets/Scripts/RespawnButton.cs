using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnButton : MonoBehaviour
{
    public string LevelToLoad;
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
        Debug.Log("Not loading");
    }
}
