using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangePlaneAnchorScript : MonoBehaviour {
    public ContentPositioningBehaviour behavior;
    public AnchorBehaviour anchor;

    public void ChangePlaneAnchor()
    {
        behavior.AnchorStage = anchor;
    }
}
