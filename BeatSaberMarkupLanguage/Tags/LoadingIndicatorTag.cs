﻿using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace BeatSaberMarkupLanguage.Tags
{
    public class LoadingIndicatorTag : BSMLTag
    {
        private GameObject loadingTemplate;

        public override string[] Aliases => new string[] {"loading", "loading-indicator"};

        public override GameObject CreateObject(Transform parent)
        {
            if (loadingTemplate == null)
                loadingTemplate = Resources.FindObjectsOfTypeAll<GameObject>().Where(x => x.name == "LoadingIndicator").First();
            GameObject loadingIndicator = Object.Instantiate(loadingTemplate, parent, false);
            loadingIndicator.name = "BSMLLoadingIndicator";

            loadingIndicator.AddComponent<LayoutElement>();

            return loadingIndicator;
        }
    }
}
