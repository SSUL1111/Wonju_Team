using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeanStiller : MonoBehaviour
{
    public AudioSource audioSource; // ����� �ҽ�
    

    void Update()
    {
        // ������� �������� üũ
        if (!audioSource.isPlaying)
        {
            // �� ��ȯ
            SceneManager.LoadScene("E_A_Attraction_Amusement_Food_Introduction");
        }
    }
}
