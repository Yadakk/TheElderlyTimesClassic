using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandmaDataHolder : MonoBehaviour
{
    public GrandmaData GrandmaData;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = GrandmaData.Sprite;
    }
}
