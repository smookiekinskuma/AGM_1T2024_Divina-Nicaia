using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Curve : MonoBehaviour
{
    [SerializeField] private Transform p1, p2, p3, p4, p5, p6;
    [SerializeField] private Transform p12, p23, p34, p45, p56, p61;

    [SerializeField] private float time;
    [SerializeField] private float totalTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        p12.position = Vector2.Lerp(p1.position, p2.position, time / totalTime);
        p23.position = Vector2.Lerp(p2.position, p3.position, time / totalTime);
        p34.position = Vector2.Lerp(p3.position, p4.position, time / totalTime);
        p45.position = Vector2.Lerp(p4.position, p5.position, time / totalTime);
        p56.position = Vector2.Lerp(p5.position, p6.position, time / totalTime);
        p61.position = Vector2.Lerp(p5.position, p6.position, time / totalTime);

        var point1 = Vector2.Lerp(p12.position, p23.position, time / totalTime);
        var point2 = Vector2.Lerp(p23.position, p34.position, time / totalTime);
        var point3 = Vector2.Lerp(p34.position, p45.position, time / totalTime);
        var point4 = Vector2.Lerp(p45.position, p56.position, time / totalTime);
        var point5 = Vector2.Lerp(p56.position, p61.position, time / totalTime);

        var point6 = Vector2.Lerp(point1, point2, time / totalTime);
        var point7 = Vector2.Lerp(point2, point3, time / totalTime);
        var point8 = Vector2.Lerp(point3, point4, time / totalTime);
        var point9 = Vector2.Lerp(point4, point5, time / totalTime);

        var point10 = Vector2.Lerp(point6, point7, time / totalTime);
        var point11 = Vector2.Lerp(point7, point8, time / totalTime);
        var point12 = Vector2.Lerp(point8, point9, time / totalTime);

        var point13 = Vector2.Lerp(point10, point11, time / totalTime);
        var point14 = Vector2.Lerp(point11, point12, time / totalTime);

        this.transform.position = Vector2.Lerp(point13, point14, time / totalTime);
    }

}
