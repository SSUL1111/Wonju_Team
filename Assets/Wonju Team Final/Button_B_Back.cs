using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_B_Back : MonoBehaviour
{
    public AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackButton()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        myAudio.Play(); // �Ҹ� ���
        yield return new WaitForSeconds(2.0f); // 2�� ���
        SceneManager.LoadScene("D"); // �� �ε�
    }
}
