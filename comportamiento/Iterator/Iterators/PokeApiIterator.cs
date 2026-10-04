using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Iterator.Interfaces;
using Iterator.Models;

namespace Iterator.Iterators
{
    public class PokeApiIterator : IIterator<Pokemon>
    {
        private readonly HttpClient _httpClient;
        private string? _nextUrl;
        private Queue<Pokemon> _currentBatch;
        
        public PokeApiIterator()
        {
            _httpClient = new HttpClient();
            _nextUrl = "https://pokeapi.co/api/v2/pokemon?limit=10";
            _currentBatch = new Queue<Pokemon>();
        }

        public async Task<bool> HasNextAsync()
        {
            if (_currentBatch.Count > 0)
            {
                return true;
            }

            if (!string.IsNullOrEmpty(_nextUrl))
            {
                Console.WriteLine($"\n[Red] -> Solicitando más Pokémon desde PokeAPI...");
                bool success = await LoadNextPageAsync();
                return success && _currentBatch.Count > 0;
            }

            return false;
        }

        public Pokemon Next()
        {
            if (_currentBatch.Count == 0)
            {
                throw new InvalidOperationException("No hay más elementos. Llama a HasNextAsync() primero.");
            }

            return _currentBatch.Dequeue();
        }

        private async Task<bool> LoadNextPageAsync()
        {
            try
            {
                if (string.IsNullOrEmpty(_nextUrl)) return false;

                var response = await _httpClient.GetStringAsync(_nextUrl);
                using JsonDocument doc = JsonDocument.Parse(response);
                
                var root = doc.RootElement;

                _nextUrl = root.GetProperty("next").ValueKind != JsonValueKind.Null 
                            ? root.GetProperty("next").GetString() 
                            : null;

                var results = root.GetProperty("results");
                foreach (var item in results.EnumerateArray())
                {
                    _currentBatch.Enqueue(new Pokemon
                    {
                        Name = item.GetProperty("name").GetString() ?? "Unknown",
                        Url = item.GetProperty("url").GetString() ?? ""
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error de Red]: {ex.Message}");
                return false;
            }
        }
    }
}
