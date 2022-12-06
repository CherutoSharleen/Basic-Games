using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnpoint;
    int score = 0;
    public TextMeshProUGUI scoreText;
    // public GameObject playButton;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            //spawn obstacles after random time of delay
            float waitTime = Random.Range(0.8f,2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnpoint.position, Quaternion.identity);
        }
    }

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void GameStart()
    {
        player.SetActive(true);
        // playButton.SetActive(false);

        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp",2f,2f); // call score up function after 2 seconds and then call it after every 1 second
        
    }
}
