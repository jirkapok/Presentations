# Nuget, Chocolatey and other confectionery

Goal of this workshop is to present the most popular packaging systems on Windows and their general usage.

## NUGET

* Command line reference see. : https://docs.microsoft.com/en-us/nuget/tools/nuget-exe-cli-reference

```powershell
.\nuget.exe update -self
.\nuget.exe help # where is uninstall command? :-)
.\nuget.exe sources list
```

* WTF? - nuget takes nuget.config in each directory up to root (Which file is edited by visual studio? root).
* Remove default source using nuget.config - how nuget.org was unavailable

```powershell
type "$($env:appdata)\nuget\nuget.config"
```

* Edit nuget.config by adding exclusion
* Edit nuspec using package explorer
* Present semantic versioning: http://semver.org/

```powershell
.\nuget.exe pack .\Nuspecs\CustomDependency.nuspec -version 1.0.0-alpha1 -OutputDirectory .\LocalPackages\
.\nuget.exe pack .\Nuspecs\CustomDependency.nuspec -version 1.0.0-alpha2 -OutputDirectory .\LocalPackages\
.\nuget.exe pack .\Nuspecs\CustomDependency.nuspec -version 1.0.1-alpha1 -OutputDirectory .\LocalPackages\
.\nuget.exe pack .\Nuspecs\CustomDependency.nuspec -version 1.0.1-alpha2 -OutputDirectory .\LocalPackages\
.\nuget.exe pack .\Nuspecs\Custompackage.nuspec -version 1.0.1-alpha1 -OutputDirectory .\LocalPackages\
.\nuget.exe list # WTF? - by default lists only release versions
.\nuget.exe list -prerelease -allversions # for concrete package add its name
.\nuget.exe install custompackage -prerelease -ExcludeVersion # installs customdependency.1.0.1-aplpha1
```

* Create custom repository using network share
Show directory structure and present hosting possibilities custom server
 * https://www.jfrog.com/artifactory/
 * https://docs.microsoft.com/en-us/nuget/hosting-packages/overview)

```powershell
.\nuget.exe init .\LocalPackages\ .\OptimizedLocalPackages
```

* Problematic situations:
 * I want to install packages without project file (download build dependencies before solution compilation).
 * I want to install packages from multiple repositories.

```powershell
.\nuget.exe restore packages.config # doesn't have project/solution file
```

 * What happens, when we from Visual Studio do package update? Installs latest version and overwrites project files. It is recommended to disable version in package directory name using nuget.config.
 * Version command vs. range in nuspec? Empty version is dangerous, i never know what happens.
 * What happens, if binary file is in content directory? Visual studio adds binary files to solution files.
 * What happens, if versions are on forth position? see last example.
 * Why nuget doesn't contain uninstall command? Because developers don't need to remove.
 * Why each install consumes disk space? Nuget has cache which caches all versions of all packages.

## PAKET

```powershell
.\paket.exe convert-from-nuget --force # it is clear in paket.exe.
.\paket.exe find-packages searchtext custompackage
.\paket.exe find-package-versions nuget custompackage
```

* compare nuget vs. paket
Why do you need nuget? To be able download paket.

| Feature                      | Nuget         | Paket    | 
| ---                          | ---           | ---      | 
| Strategy                     | Lower         | Higher   | 
| Ability to change strategy   | NO            | YES      |
| Different sources            | NO            | YES      | 
| Versions range in config     | NO            | YES      |
| Integration s Visual studio  | YES           | YES      |
| Uninstall                    | only from  VS | YES      |

## CHOCOLATEY

* Mention, that chocolatey installs it self using powershell script or nuget download.

```powershell
iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex; # actual installation
choco; # get choco version
choco sources disable -n=Chocolatey; # disable default source
choco source add -s .\ChocoSource\ -n=MyPackages; # add custom local source
choco search terminals -v # search for a package in remote repo and show details
```

* Introduce installer vs. portable a autouninstaller

```powershell
choco search terminals -a
choco install terminals
choco list -l; # show packages installed locally
choco uninstall terminals
choco new bob # create new package template
```

* Compare nuget package and choco package - Choco is nuget extended by metadata and install/uninstall powershell script.
* Show package upload to chocolatey

## PackageManagment (ONEGET)

Introduce status:
* Windows management framework: https://www.microsoft.com/en-us/download/details.aspx?id=50395
* Nobody implemented the providers yet: https://github.com/OneGet/oneget/wiki/Provider-Requests

```powershell
Get-Module # ensure, OneGet module is available
Import-Module PackageManagement; # import oneget / package management module
gcm -module PackageManagement; # show available commands
Install-PackageProvider -name chocolateyget # two providers are available, choose one.
Get-PackageSource; # no one is trustful
Register-PackageSource -Name chocolatey -Location http://chocolatey.org/api/v2 -Provider chocolateyget -Trusted # add chocolatey
Set-PackageSource chocolateyget -trusted; # setup packagesource ass trustful
Register-PackageSource -Name MyPackages -Location .\LocalPackages\ -trusted -ProviderName nuget # doesnt work with chocolatey
find-package -Source MyPackages -AllVersions # Trick: add local chocolatey source as nuget provider
```

* Introduce difference between direct call to choco and call choco using OneGet
If you use "chocolateyget" everything works as expected, i.e. choco sees identical packages.

```powershell
choco list -l
get-package -ProviderName chocolateyget
```

## APPX

* requires Windows 10 creators udpate and Visual Studio 2017 to create package
* Introduce builder in Visual Studiu 2017 (https://docs.microsoft.com/en-us/windows/uwp/porting/desktop-to-uwp-packaging-dot-net)
* Show Installation of appx package (Normal provider, which can be added to OneGet)

```powershell
find-PackageProvider appxget | fl
```
