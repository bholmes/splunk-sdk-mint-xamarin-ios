 /*
    Copyright 2015 Splunk, Inc.
    *
    Licensed under the Apache License, Version 2.0 (the "License"): you may
    not use this file except in compliance with the License. You may obtain
    a copy of the License at
    *
    *     http://www.apache.org/licenses/LICENSE-2.0
    *
    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
    WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
    License for the specific language governing permissions and limitations
    under the License.
*/

using System;
using ObjCRuntime;

[assembly: LinkWith ("libSplunkMint-iOS.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, Frameworks = "CoreTelephony SystemConfiguration UIKit Foundation CoreGraphics", LinkerFlags = "-ObjC -all_load -lz -lstdc++", ForceLoad = true )]
