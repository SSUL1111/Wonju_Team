using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public int totalDifferences = 3; // 총 차이 개수
    private int foundDifferences = 0; // 찾은 차이 개수
    public Text resultText; // 결과 텍스트 (게임 승리 시 메시지 출력)
    public string stamp;

    // 차이를 찾았을 때 호출되는 함수
    public void FoundDifference()
    {
        foundDifferences++;

        // 모든 차이를 찾으면 게임 승리 처리
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
