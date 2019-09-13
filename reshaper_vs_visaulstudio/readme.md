# Resharper vs. Visual studio

Purpose of these presentation was to have a look and compare plain Visual Studio 2019 Enterprise and Visual Studio 2019 Professional with Resharper to be able distinguish if Resharper still makes sence.

## Notes

* Features were explored on example C# code from [Terminals project](https://github.com/Terminals-Origin/Terminals)
* Not comparing performance, since there is no objective measure.
* Not comparing feautres, which arent available in both environments.
* Resharper used with Keyboard shortcuts configured with Visual Studio scheme.

## Features to compare

* Search
    * Class/Member/File (Ctrl+T) - both support all kind of searches and filtering 
    * Camel casing (search for "FCEC") - both support
    * Go to base class (FavoriteConfigurationElementCollection) - Not in VS
    * Go to member/interface implementation (Resharper right click "Navigate To", ICredentialBase) - Not in VS
    * Find usages (Shift+F12) - Resharper not editable preview, multiple tabs; VS opens the line directly, new search replaces previous
* Refactorings
    * Rename (settings field) - both allow preview and related symbols
    * Move class/method (Test method, SetDefaultFileLocations) - Only move class to its own file in VS
    * Extract class/interface - Only interface in VS
    * Add using from Nuget package (ConfigurationSettingsTests - add Moq) - both are able to find the package on nuget.org
* Test Explorer
    * Search class or test by name - both filter
    * Code coverage - both coverage report with drilldown, colloring, VS no search, but select by test run
    * Live testing vs. Resharper continuous testing (FilePersistence.Favorites) - both watching for file changes
* Code Styling
    * Find code issues
    * Batch code cleanup - both
    * Team Shared settings - both
* Price and buy conditions (Yearly billing renewal, i.e. lowest price)
    * [Visual Studio](https://visualstudio.microsoft.com/vs/pricing/)
    * [Resharper](https://www.jetbrains.com/resharper/buy/#commercial?billing=yearly)

|Product|Price|
|-|-|
|Visual studio Professional|$799|
|Visual studio Enterprise|$2569|
|Resharper|$179|


## Results

## Links

* [Visual Studio Refactorings](https://docs.microsoft.com/en-us/visualstudio/ide/refactoring-in-visual-studio?view=vs-2019)
* [Comparison by JetBrains](https://www.jetbrains.com/resharper/compare/resharper-vs-visual-studio/)