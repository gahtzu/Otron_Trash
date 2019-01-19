using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighting : MonoBehaviour
{
    private HighlightObject highlight;
    public Color highlightColor;
    // Use this for initialization
    // Update is called once per frame
    void Update()
    {
        #region Debugging
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    Highlight();
        //}
        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    UnHighlight();
        //}
        #endregion
    }

    void Awake()
    {
        highlight = new HighlightObject(transform, highlightColor);
    }

    public void Highlight()
    {
        if (highlight != null)
            highlight.Highlight();
    }

    public void UnHighlight()
    {
        if (highlight != null)
            highlight.UnHighlight();
    }
}
