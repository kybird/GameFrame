﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using LitJson;
using System.Collections.Generic;

public class UIAnimEditor : UIBasePanel
{
    private Button loadAsset;
    private Button recordAsset;
    public UIAnimEditor() : base("UI/AnimEditorUI")
    {
    }

    protected override void OnAwakeInitUI()
    {
        loadAsset = TransformExtension.FindComponent<Button>(trans, "LoadAssetButton");
        loadAsset.onClick.AddListener(ConfirmAssetInfo);

        recordAsset = TransformExtension.FindComponent<Button>(trans, "RecordAssetButton");
        recordAsset.onClick.AddListener(RecordAssetWindow);
    }

    void ConfirmAssetInfo()
    {
        UILoadAssetInfo inputAsset = UIMainManager.Instance.PopPanel<UILoadAssetInfo>(AnimAssetCtrl.Instance.root);
    }

    void RecordAssetWindow()
    {
        UIMainManager.Instance.HideCurPage();
        UIMainManager.Instance.PopPanel<UIRecordAnim>(AnimAssetCtrl.Instance.root);
    }
}
