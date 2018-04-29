﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace Microsoft.MixedReality.Toolkit.InputSystem.Utilities
{
    [Serializable]
    public enum TeleportSurfaceResult
    {
        None = 0,
        Valid,
        Invalid,
        HotSpot,
    }
}