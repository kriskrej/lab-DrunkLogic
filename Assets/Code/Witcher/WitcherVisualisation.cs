using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherVisualisation : MonoBehaviour {
    public RectTransform bar;
    public RectTransform point;
    public WitcherLogic logic;
    const float DEFAULT_BAR_WIDTH = 100;

    public float CanvasWidth {
        get { return 1000; }
    }

    public float MouseX {
        get {
            var pos01 = Mathf.Clamp01(Input.mousePosition.x / Screen.width);
            return pos01*CanvasWidth;
        }
    }

    public float BarX {
        get {
            return bar.anchoredPosition.x + CanvasWidth/2;
        }
        set {
            bar.anchoredPosition = new Vector2(value - CanvasWidth / 2, bar.anchoredPosition.y);
        }
    }

    public float BarWidth {
        get {
            return DEFAULT_BAR_WIDTH*bar.localScale.x;
        }
        set {
            bar.localScale = new Vector3(value / DEFAULT_BAR_WIDTH, bar.localScale.y, bar.localScale.z);
        }
    }

    public float PointX {
        get {
            return point.anchoredPosition.x + CanvasWidth/2;
        }
        set {
            point.anchoredPosition = new Vector2(value - CanvasWidth / 2, point.anchoredPosition.y);
        }
    }


}
