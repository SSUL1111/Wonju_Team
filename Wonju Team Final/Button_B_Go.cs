using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_B_Go : MonoBehaviour
{
    //public Button transitionButton; // 씬 전환 버튼
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoButton()
    {
        SceneManager.LoadScene("C");
    }
}
