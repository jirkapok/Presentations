$here = Split-Path -Parent $MyInvocation.MyCommand.Path
$sut = ".\Hello\Hello.psm1"
Import-Module "$here\$sut"

Describe "Hello module" {
    BeforeEach {
        Write-Host "Setting test"
    }

    AfterEach {
        Write-Host "Teardown test"
    }

    It "reports default message" {
        $message = Hello;
        $message | Should -Contain "Hello"
    }

    It "reports custom message" {
        $message = Hello "custom";
        $message | Should -Contain "custom"
    }

    It "Should not be null" {
        $message = Hello;
        $message | Should -Not -Be $Null
    }
}
