using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class ButtonAnimator : MonoBehaviour
{
    public void Shrink()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(0.7f, 0.1f));
        sequence.Append(transform.DOScale(1f, 0.1f));
    }
}
