
using System.Threading;
using TMPro;
using UdonSharp;

using UnityEngine;
using VRC.Collections;
using VRC.SDK3.Data;
using VRC.SDKBase;
using VRC.Udon;

public class TextBehaviour : UdonSharpBehaviour
{
    public TMP_Text _textMesh;


    //DataList questions = new();
    public override void Interact()
    {
        if (_textMesh != null)
        {
            _textMesh.text = "bla" ;
        }
    }
    void Start()
    {
    }
}
