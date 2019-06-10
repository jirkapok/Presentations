function Hello(
   $message = "Hello")
   {
   Write-Host $message;
   return $message;
}


# Add `Export-ModuleMember` to the module file, otherwise all functions are exported.
Export-ModuleMember "Hello"