using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difference : MonoBehaviour
{
    private bool isFound = false; // 차이를 찾았는지 여부
    public GameObject redCirclePrefab; // 빨간 원 프리팹을 할당할 변수
    AudioSource aud;
    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!isFound)
        {
            // 차이를 찾았을 때 처리
            isFound = true;

            // 게임 매니저에게 알림
            FindObjectOfType<gamemanager>().FoundDifference();

            // 클릭한 위치에 빨간 원을 생성
            ShowRedCircle();
            aud.Play();
        }
    }

    // 빨간 원을 클릭한 위치에 생성하는 함수
    void ShowRedCircle()
    {
        if (redCirclePrefab != null)
        {
            // 클릭한 오브젝트의 위치에 빨간 원 생성
            Instantiate(redCirclePrefab, transform.position, Quaternion.identity);
        }
    }
}
