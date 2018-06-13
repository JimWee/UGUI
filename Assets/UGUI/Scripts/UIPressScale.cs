using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using System;

public class UIPressScale : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public Vector3 pressed = new Vector3(1.1f, 1.1f, 1.1f);
    public float duration = 0.2f;

    private Vector3 mScale;

    private void Awake()
    {
        mScale = transform.localScale;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        transform.DOScale(pressed, duration);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        transform.DOScale(mScale, duration);

    }

    //public int flag = 0;

    //void Awake()
    //{
    //    DOTween.Init(true, true, LogBehaviour.ErrorsOnly);
    //}

    // Use this for initialization
    //   void Start () {
    //       switch (flag)
    //       {
    //           case 1:
    //               DOTween.To(() => transform.localPosition, x => transform.localPosition = x, new Vector3(100, 100, 100), 2);
    //               break;
    //           case 2:
    //               transform.DOLocalMove(new Vector3(100, 100, 100), 2).From();
    //               break;
    //           case 3:
    //               var s = DOTween.Sequence();
    //               s.Append(transform.DOLocalMove(new Vector3(100, 100, 100), 2));
    //               s.Append(transform.DOLocalRotate(new Vector3(0, 0, 90), 2));
    //               s.PrependCallback(() => Debug.Log("callback"));
    //               s.PrependInterval(1f);
    //               break;
    //           default:
    //               break;
    //       }             
    //}
}
