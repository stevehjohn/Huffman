Get-ChildItem ".\src\Huffman.Tests\Test Files" | ForEach-Object { 
    Write-Host ""
    .\src\Huffman.Console\bin\Release\netcoreapp3.1\Huffman.Console.exe benchmark -f $_.FullName
}
Write-Host ""
    