task default -depends PrepareEnvironment, Build, Test

task PrepareEnvironment {
    Import-Module pester
}

task Build {
    Write-Host "Compiled without errors."
}

task Test {
    Invoke-Pester -OutputFile testoutput.xml -Show Summary,Failed
}

task FailBuild  -depends PrepareEnvironment {
    throw "I failed on purpose!"
}