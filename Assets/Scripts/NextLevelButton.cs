using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelButton : MonoBehaviour
{
    public void OnClick()
    {
        UITopButton.instance.OnClickNext();
    }
}
