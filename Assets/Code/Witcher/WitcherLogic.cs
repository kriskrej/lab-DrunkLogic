using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherLogic : MonoBehaviour {
    public WitcherVisualisation ui;

    void Update() {
        ui.PointX = ui.MouseX;
        if (IsMouseOverBar()) {
            ui.BarX++;
        }
        else {
            ui.BarX--;
        }
        //ui.BarX = ui.MouseX;
        ui.BarWidth = (1000-ui.BarX)/4;

        
    }

    bool IsMouseOverBar() {
        return Mathf.Abs(ui.BarX - ui.MouseX) < ui.BarWidth / 2;
    }


    float life = 0.5f;
	public float GetKnobPositionInNextFrame(float currentPosition01, float mousePosition01) {
        return (currentPosition01+mousePosition01)/2;
    }
}
