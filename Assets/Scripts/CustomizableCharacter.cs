using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableCharacter : MonoBehaviour
{
    [SerializeField] private int skinNumber = 0;
    [SerializeField] private Skins[] skins;
    SpriteRenderer spriteRenderer;
    [SerializeField] private PlayerController playerController;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        SkinChoice();
    }

    private void SkinChoice() 
    {
        if (spriteRenderer.sprite.name.Contains("FiremanMain"))
        {
            if (playerController.GetIsCostumeOn() && !playerController.GetIsTankOn())
            {
                skinNumber = 1;
            }
            if (playerController.GetIsTankOn() && playerController.GetIsCostumeOn())
            {
                skinNumber = 2;
            }
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("FiremanMain_", "");
            int spriteNumber = int.Parse(spriteName);

            spriteRenderer.sprite = skins[skinNumber].sprites[spriteNumber];
        }
    }

    [System.Serializable]
    public struct Skins
    {
        public Sprite[] sprites;
    }
}
