# How to Display Tooltip and DataLabel in Release Mode in .NET MAUI Cartesian Charts

This sample demonstrates how to reliably show tooltips and data labels in Release builds of a [.NET MAUI SfCartesianChart](https://help.syncfusion.com/maui-toolkit/cartesian-charts/overview). Release mode enables code trimming, which can remove types referenced only from XAML (like converters, models, and templates). This guide explains the essentials to keep tooltips and labels functional on real devices and store builds.

## What You'll Learn

- How to keep tooltips and data labels visible in Release mode with .NET MAUI trimming enabled.
- How to structure your data and bindings so templates resolve correctly at runtime.
- How to safeguard converters, view models, and models used by XAML.

## Key Steps

1. **Ensure Chart handlers are registered** - Register Syncfusion® core so chart, tooltip, and data label handlers are available in device builds.
2. **Bind data for tooltips and datalabels** - Provide a ViewModel with your data collection and bind it to the chart to enable labels and tooltips.
3. **Use templates for UI** - Define a Tooltip template for formatted values. Define a Data Label template for how labels appear on each point.
4. **Protect XAML-Only Types from Trimming** - Preserve converters, view models, and models referenced from XAML so they aren’t removed in Release builds.
5. **Validate in Release** - Deploy a Release build to device/emulator and confirm tooltips and labels appear as expected.

## Benefits

- Consistent tooltip and label behavior in both Debug and Release builds.
- Reliable UI even with .NET trimming enabled.
- Clear, formatted information on each data point for better readability.

## Output:

<img width="347" height="719" alt="Screenshot 2025-10-31 094055" src="https://github.com/user-attachments/assets/0ba63f94-237e-496d-aaf4-f7ee31bc9ef9" />

## Troubleshooting
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [How to display tooltip and datalabel in Release Mode .NET MAUI Cartesian Chart?](https://support.syncfusion.com/kb/article/21677/why-tooltip-and-datalabel-are-missing-in-release-mode-net-maui-chart) KB article.
