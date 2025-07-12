using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture;

    void Start()
    {
        if (cursorTexture != null)
        {
            Vector2 hotspot = new Vector2(cursorTexture.width / 2f, cursorTexture.height / 2f);
            Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
        }
    }
}
