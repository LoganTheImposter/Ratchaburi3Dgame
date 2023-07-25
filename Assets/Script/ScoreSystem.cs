using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;
    [SerializeField] private TMP_Text Error;

    public const string BestTimeKey = "BestTime";

    private float score;

    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
  
    private void OnDestroy()
    {
        int BestTime = PlayerPrefs.GetInt(BestTimeKey);
        if(BestTime == 0)
        {
            BestTime = 999;
        }

        if(score < BestTime && Error.text != "01")
        {
            PlayerPrefs.SetInt(BestTimeKey, Mathf.FloorToInt(score));
        }
    }
}
