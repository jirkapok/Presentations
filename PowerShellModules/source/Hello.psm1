function Hello {
   Write-Host "Hello!";
}


# Add `Export-ModuleMember` to the module file, otherwise all functions are exported.
Export-ModuleMember "Hello"