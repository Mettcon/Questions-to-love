
using System.Threading;
using TMPro;
using UdonSharp;

using UnityEngine;
using VRC.Collections;
using VRC.SDK3.Data;
using VRC.SDKBase;
using VRC.Udon;

public class NextQuestion : UdonSharpBehaviour
{
    public TMP_Text _textMesh;
    
    //DataList questions = new();
    public override void Interact()
    {
        if (_textMesh != null)
        {
            Questions.SetQuestion();
        }
    }
}
