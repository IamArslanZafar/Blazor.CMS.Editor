﻿using System.Text.Json;
using Blazor.CMS.Editor.Application.Interfaces.Serialization.Serializers;
using Blazor.CMS.Editor.Application.Serialization.Options;
using Microsoft.Extensions.Options;

namespace Blazor.CMS.Editor.Application.Serialization.Serializers
{
    public class SystemTextJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions _options;

        public SystemTextJsonSerializer(IOptions<SystemTextJsonOptions> options)
        {
            _options = options.Value.JsonSerializerOptions;
        }

        public T Deserialize<T>(string data)
            => JsonSerializer.Deserialize<T>(data, _options);

        public string Serialize<T>(T data)
            => JsonSerializer.Serialize(data, _options);
    }
}