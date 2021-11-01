Set-Location .\src\Huffman.Console\bin\Debug\net6.0
Get-ChildItem "..\..\..\..\Huffman.Tests\Test Files\" | ForEach-Object { .\Huffman.Console.exe visualise -f $_.FullName -o "..\..\..\..\..\visualisations\$($_.BaseName).html" }
Set-Location ..\..\..\..\..\