﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RivalStrategyController : SingletonMonoBehaviour<RivalStrategyController>
{
    public IRivalStrategy Strategy
    {
        get => _strategy;
        set
        {
            _strategy = value;
            _strategy?.Initialize(this);
        }
    }

    private IRivalStrategy _strategy;

    protected override void Awake()
    {
        base.Awake();
        GetComponent<HealthController>().Death += ClearStrategy;
    }

    private void Update()
    {
        if (PauseController.Instance.IsPaused)
            return;
        Strategy?.FrameAction();
    }

    private void ClearStrategy()
    {
        Strategy = null;
    }
}
