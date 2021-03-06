﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UlsLogs
{
    [UlsEvent("nasq", "^Entering monitored scope \\((.*)\\)$")]
    public class EnteringMonitoredScope
    {
        public string Scope;
    }

    [UlsEvent("b4ly", "^Leaving Monitored Scope \\((.*)\\). Execution Time=(.*)$")]
    public class LeavingMonitoredScope
    {
        public string Scope;
        public double ExecutionTime;
    }
}
