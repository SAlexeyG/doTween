using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;

public class BlinkingAnimator : MonoBehaviour
{
    [SerializeField] private GameObject circle; 

    // Update is called once per frame
    void Update()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(circle.transform.DOScale(0f, 0.1f));
        sequence.Append(circle.transform.DOScale(1f, 0.1f));
        sequence.Append(circle.transform.DOScale(0f, 0.1f));
        sequence.Append(circle.transform.DOLocalMove(Vector3.right, 0.1f));
    }
}
