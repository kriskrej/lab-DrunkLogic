using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrunkUI : MonoBehaviour {
    [SerializeField] RectTransform bar;
    [SerializeField] RectTransform point;
    [SerializeField] DrunkLogic logic;
    const float DEFAULT_BAR_WIDTH = 100;

    /// <summary>
    /// 1000.
    /// </summary>
    public float CanvasWidth {
        get { return 1000; }
    }

    /// <summary>
    /// Horizontal position of mouse pointer, in pixels (0-1000)
    /// </summary>
    public float MouseX {
        get {
            var pos01 = Mathf.Clamp01(Input.mousePosition.x / Screen.width);
            return pos01*CanvasWidth;
        }
    }

    /// <summary>
    /// Position of center of orange bar, in pixels (0-1000)
    /// </summary>
    public float BarX {
        get {
            return bar.anchoredPosition.x + CanvasWidth/2;
        }
        set {
            bar.anchoredPosition = new Vector2(value - CanvasWidth / 2, bar.anchoredPosition.y);
        }
    }

    /// <summary>
    /// Width of orange bar, in pixels (0-1000)
    /// </summary>
    public float BarWidth {
        get {
            return DEFAULT_BAR_WIDTH*bar.localScale.x;
        }
        set {
            bar.localScale = new Vector3(value / DEFAULT_BAR_WIDTH, bar.localScale.y, bar.localScale.z);
        }
    }

    /// <summary>
    /// Position of center of red dot (mouse pointer), in pixels (0-1000)
    /// </summary>
    public float PointX {
        get {
            return point.anchoredPosition.x + CanvasWidth/2;
        }
        set {
            point.anchoredPosition = new Vector2(value - CanvasWidth / 2, point.anchoredPosition.y);
        }
    }


}
