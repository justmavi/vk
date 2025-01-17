using Newtonsoft.Json;
using System;
using VkNet.Model.GroupUpdate;

namespace VkNet.Utils.JsonConverter
{
	/// <inheritdoc />
	public class SecretConverter : JsonConverter<Secret>
	{
		/// <inheritdoc />
		public override Secret ReadJson(JsonReader reader, Type objectType, Secret existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			if (reader.Value == null)
				return null;

			return new Secret(reader.Value.ToString());
		}

		/// <inheritdoc />
		public override void WriteJson(JsonWriter writer, Secret value, JsonSerializer serializer)
		{
			writer.WriteValue(value?.Value);
		}
	}
}
