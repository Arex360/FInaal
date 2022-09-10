using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class textscore : MonoBehaviour
{
    public static int score_value;
    public Text score;
    public Text Level;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        Level= GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = score_value.ToString();
      //  Level.text = levelName.text;
        //score.text = Level.text;
    }
}

