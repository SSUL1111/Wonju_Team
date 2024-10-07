using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeanStiller : MonoBehaviour
{
    public AudioSource audioSource; // 오디오 소스
    

    void Update()
    {
        // 오디오가 끝났는지 체크
        if (!audioSource.isPlaying)
        {
            // 씬 전환
            SceneManager.LoadScene("E_A_Attraction_Amusement_Food_Introduction");
        }
    }
}
