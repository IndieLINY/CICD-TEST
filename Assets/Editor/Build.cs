using System;
using System.Collections;
using System.Collections.Generic;
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
            Debug.Log("S");
            Environment.Exit(0);
        }
        else
        {
            Debug.Log("F");
            Environment.Exit(1);
        }
    }

    public int callbackOrder => 0;
}