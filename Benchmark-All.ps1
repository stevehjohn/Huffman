Get-ChildItem ".\src\Huffman.Tests\Test Files" | ForEach-Object { 
    Write-Host ""
    .\src\Huffman.Console\bin\Release\net6.0\Huffman.Console.exe benchmark -f $_.FullName
}
Write-Host ""
    