using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difference : MonoBehaviour
{
    private bool isFound = false;
    public GameObject redCirclePrefab;
    AudioSource aud;
    void Start()
    {
        // 오브젝트에 부착된 AudioSource 컴포넌트 가져오기
        aud = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if (!isFound)
        {
            // 클릭하면 차이를 찾은 것으로 처리
            isFound = true;
            FindObjectOfType<Gamemanager>().FoundDifference(); // 게임 매니저에게 알림
            ShowRedCircle();
            aud.Play();
        }
    }
    void ShowRedCircle()
    {
        if (redCirclePrefab != null)
        {
            // 클릭한 오브젝트의 위치에 빨간 원 생성
            Instantiate(redCirclePrefab, transform.position, Quaternion.identity);
        }
    }
}
