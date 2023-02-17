using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Golden Bridge/Book", fileName = "_NewBook")]
public class BookTemplate : ScriptableObject
{
    public List<PageTemplate> Pages = new List<PageTemplate>();

    [Header("Some Possible Fields")]
    public SpriteRenderer NumberIndicatorPrefab;
    public AudioClip Music;
    public SpriteRenderer CoverBackground;
}
