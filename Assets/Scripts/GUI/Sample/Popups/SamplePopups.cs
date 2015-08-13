﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SamplePopups : BasePopups
{
    Button btnOk;

    public void Start()
    {
        btnOk = Util.Get<Button>(this.gameObject, "OK");
        btnOk.onClick.AddListener(() =>
            {
                Hide();
            });
    }

    public override void ResetParametres()
    {
    
    }

    
    
}
