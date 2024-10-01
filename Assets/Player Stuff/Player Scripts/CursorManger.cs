using UnityEngine;

public class CursorManger : MonoBehaviour
{

    public Texture2D cursorDiamond;

    void Start()
    {
        Cursor.SetCursor(cursorDiamond, Vector2.zero, CursorMode.ForceSoftware);
    }

}
