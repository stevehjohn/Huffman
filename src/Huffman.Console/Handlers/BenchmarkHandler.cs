using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Huffman.Console.Options;
using static System.Console;

namespace Huffman.Console.Handlers;

[ExcludeFromCodeCoverage]
public class BenchmarkHandler
{
    private readonly BenchmarkOptions _options;

    public BenchmarkHandler(BenchmarkOptions options)
    {
        _options = options;
    }

    public void Execute()
    {
        var file = File.ReadAllText(_options.FileName);

        var timer = new Stopwatch();

        var averageCompression = 0L;

        byte[] compressed = null;

        WriteLine();

        for (var i = 0; i < _options.Cycles; i++)
        {
            timer.Start();

            compressed = Compression.Compress(file);

            timer.Stop();

            if (! _options.Quiet)
            {
                WriteLine($"Time taken to compress: {timer.ElapsedMilliseconds:N0} ms.");
            }

            averageCompression += timer.ElapsedMilliseconds;

            timer.Reset();
        }

        WriteLine();

        var averageDecompression = 0L;

        string decompressed = null;

        for (var i = 0; i < _options.Cycles; i++)
        {
            timer.Start();

            decompressed = Compression.Decompress(compressed);

            timer.Stop();

            if (! _options.Quiet)
            {
                WriteLine($"Time taken to decompress: {timer.ElapsedMilliseconds:N0} ms.");
            }

            averageDecompression += timer.ElapsedMilliseconds;

            timer.Reset();
        }

        WriteLine();
            
        WriteLine($"Filename: {Path.GetFileNameWithoutExtension(_options.FileName)}");

        WriteLine();

        WriteLine($"Uncompressed file size: {file.Length:N0} bytes.");

        if (compressed == null)
        {
            throw new NullReferenceException("Compressed output is null.");
        }

        WriteLine($"Compressed file size:   {compressed.Length:N0} bytes.");

        WriteLine();

        WriteLine($"Ratio: {(float) compressed.Length / file.Length * 100:N2}%");

        WriteLine();

        if (decompressed == null)
        {
            throw new NullReferenceException("Decompressed output is null.");
        }

        if (file.Length != decompressed.Length)
        {
            WriteLine("Decompressed and source files ARE NOT the same size.");
        }

        WriteLine();

        WriteLine($"Average time taken to compress over {_options.Cycles} cycle{(_options.Cycles > 1 ? "s" : string.Empty)}:   {averageCompression / _options.Cycles:N0} ms.");

        WriteLine($"Average time taken to decompress over {_options.Cycles} cycle{(_options.Cycles > 1 ? "s" : string.Empty)}: {averageDecompression / _options.Cycles:N0} ms.");

        if (Debugger.IsAttached)
        {
            WriteLine();

            WriteLine("Press any key to exit.");

            ReadKey();
        }
    }
}