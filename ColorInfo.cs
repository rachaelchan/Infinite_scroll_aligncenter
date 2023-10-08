using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Color", menuName = "SO/ColorInfo", order = 1)]
public class ColorInfo : ScriptableObject
{
    public string colorName;
    public Sprite sprite;
    public string descritption;
}
