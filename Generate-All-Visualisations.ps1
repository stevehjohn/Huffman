Set-Location .\src\Huffman.Console\bin\Debug\netcoreapp3.1
Get-ChildItem "..\..\..\..\Huffman.Tests\Test Files\" | ForEach-Object { .\Huffman.Console.exe -f $_.FullName -o "..\..\..\..\..\visualisations\$($_.BaseName).html" }
Set-Location ..\..\..\..\..\