using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScale : MonoBehaviour
{
    public Vector2 sizeChange = new Vector2(50f, 50f); // 증가할 크기
    public float duration = 0.3f; // 크기가 증가할 시간

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // 일정한 속도로 UI 요소 크기를 증가
        rectTransform.sizeDelta += sizeChange * Time.deltaTime / duration;

        // 크기가 일정 이상이 되면 멈추기 (원하는 조건으로 조정 가능)
        if (rectTransform.sizeDelta.x > 1000f) // 예: 최대 너비 1000
        {
            enabled = false; // 스크립트 비활성화
        }
    }
}
