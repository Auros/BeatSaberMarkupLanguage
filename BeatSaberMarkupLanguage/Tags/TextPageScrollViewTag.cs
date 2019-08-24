﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BeatSaberMarkupLanguage.Tags
{
    public class TextPageScrollViewTag : BSMLTag
    {
        public override string[] Aliases => new[] { "text-page" };

        public override GameObject CreateObject(Transform parent)
        {
            TextPageScrollView scrollView = MonoBehaviour.Instantiate(Resources.FindObjectsOfTypeAll<TextPageScrollView>().First(x => x.transform.parent.gameObject.name == "ReleaseInfoViewController"), parent);
            scrollView.name = "BSMLTextPageScrollView";
            scrollView.enabled = true;
            return scrollView.gameObject;
        }
    }
}
