using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PulsingAnimator : MonoBehaviour
{
    [SerializeField] private GameObject circle1;
    [SerializeField] private GameObject circle2;

    private IEnumerator Start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(circle1.transform.DOScale(1f, 1f));
        sequence.Join(circle1.GetComponent<Material>().DOFade(1f, 1f));

        yield return new WaitForSeconds(0.1f);

        sequence.Append(circle2.transform.DOScale(1f, 1f));
        sequence.Join(circle2.GetComponent<Material>().DOFade(1f, 1f));
    }
}
