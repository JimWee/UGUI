using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UISpriteAtlas", menuName = "UI Sprite Atlas", order = 1)]
class UISpriteAtlas : ScriptableObject
{
    public Sprite[] Sprites;

    public int spriteCount
    {
        get
        {
            if (Sprites != null)
            {
                return Sprites.Length;
            }
            return 0;
        }
    }

    public Sprite GetSprite(string name)
    {
        if (Sprites != null)
        {
            foreach (var sprite in Sprites)
            {
                if (sprite != null && sprite.name == name)
                {
                    return sprite;
                }
            }
        }

        return null;
    }

    public Sprite[] GetSprites()
    {
        return Sprites;
    }
}
