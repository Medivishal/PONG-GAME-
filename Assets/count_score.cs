using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class count_score : MonoBehaviour
{
    public Text scoreboard;
    public GameObject pong;
    public static bool canAddscore = true;
    
    private int pong_1_score = 0;
    private int pong_2_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        pong = GameObject.Find("pong");
    }

    // Update is called once per frame
    void Update()
    {
        if (pong.transform.position.x >= 20f && canAddscore)
        {
            canAddscore = false;
            pong_1_score ++;
        }
        if (pong.transform.position.x <= -20f && canAddscore)
        {
            canAddscore = false; 
            pong_2_score ++;
        }
        if(pong_1_score >= 7)
        {
            SceneManager.LoadScene (2);
        }
        if(pong_2_score >= 7)
        {
            SceneManager.LoadScene (3);
        }
        scoreboard.text = pong_1_score.ToString () + " - " + pong_2_score.ToString();


           print (pong_1_score + " , " + pong_2_score);
    }
}
