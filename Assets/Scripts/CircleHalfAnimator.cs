using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;

public class CircleHalfAnimator : MonoBehaviour
{
    [SerializeField] private GameObject circle1;
    [SerializeField] private GameObject circle2;

    private void Update()
    {
        circle1.transform.DORotate(circle1.transform.eulerAngles +
            new Vector3(0, 0, 180), 1f);
        circle2.transform.DORotate(circle2.transform.eulerAngles +
            new Vector3(0, 0, -180), 1f);
    }
}
