using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SeceneManger : MonoBehaviour
{
    public  string levelName;
    // Start is called before the first frame update
    public void easy()
    {
        levelName = "Easy";
        SceneManager.LoadScene("Connect to server");

    }
    public void Medium()
    {
        levelName = "Medium";
        SceneManager.LoadScene("Connect to server");
    }
    public void Hard()
    {
        levelName = "Hard";
        SceneManager.LoadScene("Connect to server");
    }


}
