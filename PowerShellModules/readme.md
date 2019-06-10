# PowerShell modules and testing

Source code and materials for powershell modules development and testing in powershell.

* Use Run/Debug buttons in VS code to run tests
* Use Terminal in VS code to run Powershell commands

## Tasks

### Working with modules

```powershell
# List packages source, which contains PsGalery online repository
Get-PackageSource | ft -AutoSize
# Find example package
Find-Module posh-git
# Import Git commands support to powershell
Install-Module posh-git
Import-Module posh-git
# List paths where powershell searches for modules - observe the directory structure
$env:PSModulePath
# List commands published by the module
Get-Command -Module posh-git
# Import the module from file
Import-Module .\Hello\Hello.psm1
```

### Create custom module

```powershell
# Create dynamic in memory module and import it
# To override the already loaded module, restart powershell
# observe its commands
New-Module -Name Hello -ScriptBlock {function Hello {"Hello!"}} | Import-module
# Create new manifest file and edit its content mainly: RootModule, FileList, FunctionsToExport
New-ModuleManifest .\Hello\Hello.psd1
# Edit the file and test the module definition
Test-ModuleManifest .\Hello\Hello.psd1
```

### Write tests

```powershell
Import-Module pester
Get-Command -Module pester
# Create script with tests creates two ps1 files
New-Fixture
# Invoke the tests from command line
Invoke-Pester
# Play with the asserts and before and after each
# Check the code coverage
Invoke-Pester -CodeCoverage *.*
# Generates NUnitXml file
Invoke-Pester -OutputFile testoutput.xml -Show Summary,Failed
```

### Automate using Psake

```powershell
# make the psake available
Import-Module psake
# Execute the default script file with "default" task
Invoke-Psake
# Run customized build
Invoke-psake -buildFile .\psakefile.ps1 -task FailBuild
```

### Host your Modules

```powershell
# Register new repository
New-Item C:\PsRepository -ItemType Directory -Force
Register-PSRepository -Name "Custom" -SourceLocation C:\PsRepository -PublishLocation C:\PsRepository -InstallationPolicy Trusted
# Publish the module module needs to be placed inside directory with the same name as the module script
Publish-Module -Path .\Hello -Repository "Custom"
# observe the repository directory content
# Use all other commands to find, list, install or import your module
```

## Resources

### Tools used

* Powershell 5.1+
* [Visual Studio Code](https://code.visualstudio.com/)
* [Visual Studio Code PowerShell extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.PowerShell)
* [Pester](https://github.com/pester/Pester)
* [Psake](https://github.com/psake/psake)

### Links

* https://docs.microsoft.com/en-us/powershell/developer/module/how-to-write-a-powershell-script-module
* https://www.pluralsight.com/courses/psmodules
* https://www.youtube.com/watch?v=AgCRjWRliwE
* https://www.powershellgallery.com/
* https://docs.microsoft.com/en-us/powershell/scripting/components/vscode/using-vscode?view=powershell-6