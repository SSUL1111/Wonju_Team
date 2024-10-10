using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int totalDifferences = 3; // 총 차이 개수
    private int foundDifferences = 0; // 찾은 차이 개수
    public Text resultText;
    public string stamp;
    public void FoundDifference()
    {
        foundDifferences++;

        // 모든 차이를 찾으면 승리
        if (foundDifferences >= totalDifferences)
        {
            GameWon();
        }
    }

    // 게임 승리 처리
    private void GameWon()
    {
        resultText.text = "축하합니다! 모든 차이를 찾았습니다!";
        Invoke("LoadNextScene", 3f);
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene("stamp"); // 지정된 씬으로 전환
    }
}
