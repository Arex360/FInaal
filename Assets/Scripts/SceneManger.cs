using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    // Start is called before the first frame update
    public void playoffline()
    {
        SceneManager.LoadScene("Playoffline");
    }
    public void playonline()
    {
        SceneManager.LoadScene("Connect to server");
    }

}
