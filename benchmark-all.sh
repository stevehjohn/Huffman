#!/usr/bin/env zsh

# Define the directory containing test files
test_dir="./src/Huffman.Tests/Test Files"

# Loop over all files in the directory
for file in "$test_dir"/*; do
  echo ""
  ./src/Huffman.Console/bin/Release/net6.0/Huffman.Console benchmark -f "$file"
done

echo ""
