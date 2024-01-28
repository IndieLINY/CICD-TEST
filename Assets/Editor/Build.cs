using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.Build;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Build : IPostprocessBuildWithReport
{
    public void OnPostprocessBuild(BuildReport report)
    {
        if (report.summary.result == BuildResult.Succeeded)
        {
            Task.Run(async () =>
            {
                await Task.Delay(60000);
                Environment.Exit(0);
            });
        }
        else
        {
            Task.Run(async () =>
            {
                await Task.Delay(60000);
                Environment.Exit(1);
            });
        }
    }

    public int callbackOrder => 0;
}