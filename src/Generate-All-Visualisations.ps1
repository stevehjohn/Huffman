Set-Location .\Huffman.Console\bin\Debug\netcoreapp3.1
Get-ChildItem ..\..\..\..\..\visualisations\ | ForEach-Object { .\Huffman.Console.exe -f $_.FullName }
Set-Location ..\..\..\..\