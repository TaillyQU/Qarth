﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace  GFrame.Drama
{

    [CustomNodeEditor(typeof(DialogueStart))]
    public class DialogueStartEditor : NodeEditor
    {
        public override Color GetTint()
        {
            if (EditorGUIUtility.isProSkin)
            {
                //黑色界面
                return new Color(205f / 255f, 55f / 255f, 0f, 1f);
            }
            else
            {
                //浅色界面
                return new Color(255f / 255f, 192f / 255f, 203f / 255f, 1f);
            }
        }

        public override int GetWidth()
        {
            return 200;
        }
    }
}
