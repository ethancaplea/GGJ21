using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableFog : MonoBehaviour
{
    private void OnPreRender()
    {
        RenderSettings.fog = false;
    }
}