using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Golden Bridge/Book Page", fileName = "_NewPage")]
public class PageTemplate : ScriptableObject
{
    [Header ("Static Images")]
    public SpriteRenderer Background;
    public SpriteRenderer ColoredImage;
    public SpriteRenderer BlackAndWhiteImage;

    [Space]
    [Header ("Masks")]
    [Tooltip("Activated with user interaction.")] public GameObject DynamicMasks;
    [Tooltip ("Always active.")] public GameObject StaticMasks;
}
